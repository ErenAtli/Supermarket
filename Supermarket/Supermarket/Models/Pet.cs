﻿using System.ComponentModel.DataAnnotations;

namespace Supermarket.Models
{
    public class Pet
    {
        [Key] public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Category { get; set; }

        public int Price { get; set; }

    }
}
