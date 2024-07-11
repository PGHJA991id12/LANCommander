﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LANCommander.Client.Data.Models
{
    [Table("Genres")]
    public class Genre : BaseTaxonomyModel
    {
        public string Name { get; set; }
        [JsonIgnore]
        public virtual ICollection<Game> Games { get; set; }
    }
}
