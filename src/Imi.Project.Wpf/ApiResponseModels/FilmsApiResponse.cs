﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.ApiResponseModels
{
    public class FilmsApiResponse
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("releaseYear")]
        public int ReleaseYear { get; set; }

        [JsonPropertyName("image")]
        public string? Image { get; set; }

        [JsonPropertyName("director")]
        public DirectorsApiResponse Director { get; set; }

        [JsonPropertyName("genre")]
        public GenresApiResponse Genre { get; set; }

        public override string ToString()
        {
            return $"{Title} ({ReleaseYear})";
        }
    }
}
