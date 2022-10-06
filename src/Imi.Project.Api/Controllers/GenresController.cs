using Imi.Project.Api.Core.DTOs.Genres;
using Imi.Project.Api.Core.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        protected readonly IGenreRepository _genreRepository;

        public GenresController(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var genres = await _genreRepository.ListAllAsync();
            var genresDto = genres.Select(g => new GenreResponseDto
            {
                Id = g.Id,
                Name = g.Name
            });

            return Ok(genresDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var genre = await _genreRepository.GetByIdAsync(id);
            if (genre == null)
            {
                return NotFound($"No genre found with id: {id}.");
            }
            var genreDto = new GenreResponseDto()
            {
                Id = genre.Id,
                Name = genre.Name
            };

            return Ok(genreDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var genre = await _genreRepository.GetByIdAsync(id);

            if (genre == null)
            {
                return NotFound($"Failed! No genre found with id: {id}");
            }

            await _genreRepository.DeleteAsync(genre);

            return Ok();
        }
    }
}
