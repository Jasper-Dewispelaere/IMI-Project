using System.Text.Json.Serialization;

namespace Imi.Project.Blazor.DTOs
{
    public class FilmRequestDto
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("releaseYear")]
        public int ReleaseYear { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("directorId")]
        public Guid DirectorId { get; set; }

        [JsonPropertyName("genreId")]
        public Guid GenreId { get; set; }
    }
}
