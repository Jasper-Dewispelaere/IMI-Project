using Imi.Project.Api.Core.DTOs.Genres;
using Imi.Project.Api.Core.Entities;
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

        [HttpPost]
        public async Task<IActionResult> Add(GenreRequestDto genreDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            var genre = new Genre
            {
                Name = genreDto.Name
            };
            await _genreRepository.AddAsync(genre);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(GenreRequestDto genreDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var genre = await _genreRepository.GetByIdAsync(genreDto.Id);

            if (genre == null)
            {
                return NotFound($"Failed! No genre found with id {genreDto.Id}");
            }

            genre.Name = genreDto.Name;
            await _genreRepository.UpdateAsync(genre);

            return Ok();
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
