using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Imi.Project.Blazor.DTOs
{
    public class FilmResponseDto
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("releaseYear")]
        public int ReleaseYear { get; set; }

        [JsonPropertyName("genre")]
        public GenreDto Genre { get; set; }

        [JsonPropertyName("director")]
        public DirectorDto Director { get; set; }
    }
}
