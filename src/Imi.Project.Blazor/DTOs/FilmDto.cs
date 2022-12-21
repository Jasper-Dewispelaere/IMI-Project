using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.DTOs
{
    public class FilmDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public int ReleaseYear { get; set; }
        public Guid DirectorId { get; set; }
        public string DirectorName { get; set; }
        public Guid GenreId { get; set; }
        public string GenreName { get; set; }
    }
}
