using Imi.Project.Api.Core.DTOs.Directors;
using Imi.Project.Api.Core.DTOs.Genres;
using Imi.Project.Api.Core.DTOs.Actors;
using Imi.Project.Api.Core.DTOs.Films;
using Imi.Project.Api.Core.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
            var genres = await _genreRepository.ListAllAsync();
            var directors = await _directorRepository.ListAllAsync();
            var actos = await _actorRepository.ListAllAsync();
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
    }
}
