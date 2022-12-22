using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.DTOs
{
    public class FilmDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public int ReleaseYear { get; set; }
        public GenreDto Genre { get; set; }
        public DirectorDto Director { get; set; }
    }
}
