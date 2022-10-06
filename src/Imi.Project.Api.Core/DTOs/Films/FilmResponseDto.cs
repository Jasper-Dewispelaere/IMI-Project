using Imi.Project.Api.Core.DTOs.Actors;
using Imi.Project.Api.Core.DTOs.Directors;
using Imi.Project.Api.Core.DTOs.Genres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.DTOs.Films
{
    public class FilmResponseDto : BaseDto
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public int ReleaseYear { get; set; }
        public DirectorResponseDto Director { get; set; }
        public GenreResponseDto Genre { get; set; } 
        public ICollection<ActorResponseDto> Actor { get; set; } 
    }
}
