using Imi.Project.Api.Core.DTOs.Actors;
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
