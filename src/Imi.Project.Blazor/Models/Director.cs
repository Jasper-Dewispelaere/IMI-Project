﻿using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Models
{
    public class Director
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }
        public ICollection<Film> Films { get; set; }
    }
}
