using Imi.Project.Api.Core.DTOs.Actors;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        protected readonly IActorRepository _actorRepository;

        public ActorsController(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var actors = await _actorRepository.ListAllAsync();
            var actorsDto = actors.Select(g => new ActorResponseDto
            {
                Id = g.Id,
                Name = g.Name
            });

            return Ok(actorsDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var actor = await _actorRepository.GetByIdAsync(id);
            if (actor == null)
            {
                return NotFound($"No actor found with id: {id}.");
            }
            var actorDto = new ActorResponseDto()
            {
                Id = actor.Id,
                Name = actor.Name
            };

            return Ok(actorDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ActorRequestDto actorDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            var actor = new Actor
            {
                Name = actorDto.Name
            };
            await _actorRepository.AddAsync(actor);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ActorRequestDto actorDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var actor = await _actorRepository.GetByIdAsync(actorDto.Id);

            if (actor == null)
            {
                return NotFound($"Failed! No actor found with id {actorDto.Id}");
            }

            actor.Name = actorDto.Name;
            await _actorRepository.UpdateAsync(actor);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var actor = await _actorRepository.GetByIdAsync(id);

            if (actor == null)
            {
                return NotFound($"Failed! No actor found with id: {id}");
            }

            await _actorRepository.DeleteAsync(actor);

            return Ok();
        }
    }
}
