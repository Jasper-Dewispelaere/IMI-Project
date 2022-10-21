using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.ApiRequestModels
{
    public class FilmsApiRequest
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("releaseYear")]
        public int ReleaseYear { get; set; }

        [JsonPropertyName("image")]
        public string? Image { get; set; }
        [JsonPropertyName("directorId")]
        public Guid DirectorId { get; set; }

        [JsonPropertyName("genreId")]
        public Guid GenreId { get; set; }
    }
}
