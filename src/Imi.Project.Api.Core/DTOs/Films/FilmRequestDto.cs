using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.DTOs.Films
{
    public class FilmRequestDto : BaseDto
    {
        [Required(ErrorMessage = "{0} is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string Image { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public int ReleaseYear { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public Guid DirectorId { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public Guid GenreId { get; set; }
    }
}