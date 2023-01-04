﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LANCommander.Data;
using LANCommander.Data.Models;
using Microsoft.AspNetCore.Authorization;

namespace LANCommander.Controllers
{
    [Authorize]
    public class GamesController : Controller
    {
        private readonly DatabaseContext Context;

        public GamesController(DatabaseContext context)
        {
            Context = context;
        }

        // GET: Games
        public async Task<IActionResult> Index()
        {
              return Context.Games != null ? 
                          View(await Context.Games.ToListAsync()) :
                          Problem("Entity set 'DatabaseContext.Games'  is null.");
        }

        // GET: Games/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || Context.Games == null)
            {
                return NotFound();
            }

            var game = await Context.Games
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Games/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,SortTitle,Description,ReleasedOn,Id,CreatedOn,CreatedById,UpdatedOn,UpdatedById")] Game game)
        {
            if (ModelState.IsValid)
            {
                using (Repository<Game> repo = new Repository<Game>(Context, HttpContext))
                {
                    await repo.Add(game);
                    await repo.SaveChanges();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

        // GET: Games/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            Game game;

            if (id == null || Context.Games == null)
            {
                return NotFound();
            }

            using (Repository<Game> repo = new Repository<Game>(Context, HttpContext))
            {
                game = await repo.Find(id.GetValueOrDefault());

                if (game == null)
                    return NotFound();
            }

            return View(game);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Title,SortTitle,Description,ReleasedOn,Id,CreatedOn,CreatedById,UpdatedOn,UpdatedById")] Game game)
        {
            if (id != game.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    using (Repository<Game> repo = new Repository<Game>(Context, HttpContext))
                    {
                        repo.Update(game);

                        await repo.SaveChanges();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

        // GET: Games/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || Context.Games == null)
            {
                return NotFound();
            }

            var game = await Context.Games
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (Context.Games == null)
            {
                return Problem("Entity set 'DatabaseContext.Games' is null.");
            }
            var game = await Context.Games.FindAsync(id);
            if (game != null)
            {
                Context.Games.Remove(game);
            }
            
            await Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(Guid id)
        {
          return (Context.Games?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
