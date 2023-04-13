﻿using ServiceStack.DataAnnotations;

namespace SelectAPI.Models
{
    // [Index(nameof(Email), IsUnique = true)]
    public class Collage
    {
        [PrimaryKey]
        public int CollageId { get; set; }
        public string Name { get; set; } 
    }
}
