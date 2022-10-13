using Imi.Project.Api.Core.DTOs.Directors;
using Imi.Project.Api.Core.DTOs.Genres;
using Imi.Project.Api.Core.DTOs.Actors;
using Imi.Project.Api.Core.DTOs.Films;
using Imi.Project.Api.Core.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Imi.Project.Api.Core.Entities;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        protected readonly IFilmRepository _filmRepository;
        protected readonly IDirectorRepository _directorRepository;
        protected readonly IGenreRepository _genreRepository;
        protected readonly IActorRepository _actorRepository;

        public FilmsController(IFilmRepository filmRepository, IDirectorRepository directorRepository, 
            IGenreRepository genreRepository, IActorRepository actorRepository)
        {
            _filmRepository = filmRepository;
            _directorRepository = directorRepository;
            _genreRepository = genreRepository;
            _actorRepository = actorRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var films = await _filmRepository.ListAllAsync();
            var actors = await _actorRepository.ListAllAsync();
            var filmsDto = films.Select(f => new FilmResponseDto
            {
                Id = f.Id,
                Title = f.Title,
                Image = f.Image,
                ReleaseYear = f.ReleaseYear,
                Director = new DirectorResponseDto
                {
                    Id = f.Director.Id,
                    Name = f.Director.Name
                },
                Genre = new GenreResponseDto
                { 
                    Id = f.Genre.Id,
                    Name = f.Genre.Name
                }
            });

            return Ok(filmsDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var film = await _filmRepository.GetByIdAsync(id);
            if (film == null)
            {
                return NotFound($"No film found with id: {id}.");
            }
            var filmDto = new FilmResponseDto()
            {
                Id = film.Id,
                Title = film.Title,
                ReleaseYear = film.ReleaseYear,
                Image = film.Image,
                Director = new DirectorResponseDto
                { 
                    Id = film.Director.Id,
                    Name = film.Director.Name
                },
                Genre = new GenreResponseDto
                {
                    Id = film.Genre.Id,
                    Name = film.Genre.Name
                }
            };
            return Ok(filmDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add(FilmRequestDto filmDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            var film = new Film
            {
                Title = filmDto.Title,
                ReleaseYear = filmDto.ReleaseYear,
                Image = filmDto.Image,
                DirectorId = filmDto.DirectorId,
                GenreId = filmDto.GenreId
            };
            await _filmRepository.AddAsync(film);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(FilmRequestDto filmDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var film = await _filmRepository.GetByIdAsync(filmDto.Id);

            if (film == null)
            {
                return NotFound($"Failed! No film found with id {filmDto.Id}");
            }

            film.Title = filmDto.Title;
            film.ReleaseYear = filmDto.ReleaseYear;
            film.Image = filmDto.Image;
            film.DirectorId = filmDto.DirectorId;
            film.GenreId = filmDto.GenreId;

            await _filmRepository.UpdateAsync(film);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var film = await _filmRepository.GetByIdAsync(id);

            if (film == null)
            {
                return NotFound($"Failed! No film found with id: {id}");
            }

            await _filmRepository.DeleteAsync(film);
            return Ok();
        }
    }
}
