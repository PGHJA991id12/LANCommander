using System.Linq.Expressions;
using LANCommander.Server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LANCommander.Server.Data;

public class UpdateEntityContext<TEntity>
    where TEntity : class, IBaseModel
{
    private readonly DatabaseContext _context;
    private readonly TEntity _entity;
    private readonly TEntity _updatedEntity;

    public UpdateEntityContext(DatabaseContext context, TEntity entity, TEntity updatedEntity)
    {
        _context = context;
        _entity = entity;
        _updatedEntity = updatedEntity;
    }

    public async Task UpdateRelationshipAsync<TRelatedEntity>(
        Expression<Func<TEntity, TRelatedEntity?>> navigationPropertyPath)
        where TRelatedEntity : class, IBaseModel
    {
        var compiledExpression = navigationPropertyPath.Compile();

        // Get the updated entity from the new entity
        var updatedEntity = compiledExpression.Invoke(_updatedEntity);

        if (updatedEntity != null)
        {
            var existingEntityEntry = _context.Entry(_entity);
            var navigation = existingEntityEntry.Reference(navigationPropertyPath);

            // Ensure the existing entity is loaded if needed
            if (!navigation.IsLoaded)
            {
                await navigation.LoadAsync();
            }

            // Check if an instance of updatedEntity is already being tracked
            var trackedEntity = _context.Set<TRelatedEntity>().Local
                .FirstOrDefault(e => e.Id == updatedEntity.Id);

            if (trackedEntity != null)
            {
                // Use the already tracked instance to avoid duplicate tracking
                navigation.CurrentValue = trackedEntity;
            }
            else
            {
                // Attach the updated entity and set it correctly
                _context.Attach(updatedEntity);
                navigation.CurrentValue = updatedEntity;
            }

            _context.Entry(_entity).State = EntityState.Modified;
        }
    }
    
    public async Task UpdateRelationshipAsync<TRelatedEntity>(
        Expression<Func<TEntity, IEnumerable<TRelatedEntity>>> navigationPropertyPath)
        where TRelatedEntity : class, IBaseModel
    {
        var compiledExpression = navigationPropertyPath.Compile();

        // Explicitly load the existing collection
        var navigation = _context.Entry(_entity).Collection(navigationPropertyPath);
        if (!navigation.IsLoaded)
        {
            await navigation.LoadAsync();
        }

        // Get the updated collection from the new entity
        var updatedCollection = compiledExpression.Invoke(_updatedEntity);

        if (updatedCollection is IEnumerable<TRelatedEntity> updatedEntities)
        {
            var existingCollection = compiledExpression(_entity);

            if (existingCollection is ICollection<TRelatedEntity> existingEntities)
            {
                // Get the list of tracked entities from the context
                var trackedEntities = _context.Set<TRelatedEntity>().Local;

                // Replace entities with tracked instances to avoid duplicate tracking
                var updatedTrackedEntities = updatedEntities
                    .Select(e => trackedEntities.FirstOrDefault(t => t.Id == e.Id) ?? e)
                    .ToList();
                
                // Add new entities that are missing
                foreach (var updatedEntity in updatedTrackedEntities)
                {
                    if (!existingEntities.Any(e => e.Id == updatedEntity.Id))
                        existingEntities.Add(updatedEntity);
                }

                foreach (var existingEntity in updatedTrackedEntities)
                {
                    if (!updatedEntities.Any(e => e.Id == existingEntity.Id))
                        existingEntities.Remove(existingEntity);
                }
                    
                _context.Entry(_entity).State = EntityState.Modified;
            }
        }
    }

}