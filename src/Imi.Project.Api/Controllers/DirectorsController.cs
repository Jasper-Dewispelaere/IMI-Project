using Imi.Project.Api.Core.DTOs.Directors;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        protected readonly IDirectorRepository _directorRepository;

        public DirectorsController(IDirectorRepository directorRepository)
        {
            _directorRepository = directorRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var directors = await _directorRepository.ListAllAsync();
            var directorsDto = directors.Select(g => new DirectorResponseDto
            {
                Id = g.Id,
                Name = g.Name
            });

            return Ok(directorsDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var director = await _directorRepository.GetByIdAsync(id);
            if (director == null)
            {
                return NotFound($"No director found with id: {id}.");
            }
            var directorDto = new DirectorResponseDto()
            {
                Id = director.Id,
                Name = director.Name
            };

            return Ok(directorDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add(DirectorRequestDto directorDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            var director = new Director
            {
                Name = directorDto.Name
            };
            await _directorRepository.AddAsync(director);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(DirectorRequestDto directorDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var director = await _directorRepository.GetByIdAsync(directorDto.Id);

            if (director == null)
            {
                return NotFound($"Failed! No director found with id {directorDto.Id}");
            }

            director.Name = directorDto.Name;
            await _directorRepository.UpdateAsync(director);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var director = await _directorRepository.GetByIdAsync(id);

            if (director == null)
            {
                return NotFound($"Failed! No director found with id: {id}");
            }

            await _directorRepository.DeleteAsync(director);

            return Ok();
        }
    }
}
