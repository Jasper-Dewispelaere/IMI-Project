using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Entities
{
    public class Film : BaseEntity
    {
        [Required] 
        public string Title { get; set; }
        [Required]
        public string Image { get; set; }
        public int ReleaseYear { get; set; }
        public Guid DirectorId { get; set; }
        public Director Director { get; set; }
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
        public ICollection<Actor> Actors { get; set; }
    }
}
