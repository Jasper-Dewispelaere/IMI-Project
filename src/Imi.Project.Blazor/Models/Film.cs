using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Models
{
    public class Film
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "Title is too long.")]
        public string Title { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public int ReleaseYear { get; set; }
        public Guid DirectorId { get; set; }
        public string DirectorName { get; set; }
        public Guid GenreId { get; set; }
        public string GenreName { get; set; }
        //public ICollection<Actor> Actors { get; set; }
    }
}
