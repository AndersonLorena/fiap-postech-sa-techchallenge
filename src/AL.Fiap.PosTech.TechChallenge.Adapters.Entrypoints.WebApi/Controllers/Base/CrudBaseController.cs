using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using AL.Fiap.PosTech.TechChallenge.Ports.Interfaces.Queries;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Controllers.Base
{
    [ApiController]
    [Route("[controller]")]
    public abstract class CrudBaseController<TCreateCommand, TReadDto, TUpdateCommand, TDeleteCommand, TEntity> : ControllerBase
       where TCreateCommand : CreateCommandBase<TEntity>
       where TReadDto : BaseReadResponseDto
       where TUpdateCommand : UpdateCommandBase<TEntity>
       where TDeleteCommand : DeleteCommandBase
       where TEntity : BaseEntity
    {
        protected readonly ISender _mediator;
        protected readonly IQueryRepository<TEntity> _queryRepository;
        protected readonly IMapper _mapper;

        public CrudBaseController(

            ISender mediator,
            IQueryRepository<TEntity> queryRepository,
            IMapper mapper)
        {
            _mediator = mediator;
            _queryRepository = queryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            var result = _mapper.Map<IEnumerable<TReadDto>>(
                await _queryRepository.GetAllAsync());

            return Ok(
                result);
        }

        [HttpGet("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = _mapper.Map<TReadDto>(
                await _queryRepository.GetByIdAsync(id));

            return Ok(
                result);
        }

        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(string), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post([FromBody] TCreateCommand command)
        {
            var response = await _mediator.Send(command);
            return CreatedAtAction(nameof(Get), new { id = response }, command);
        }

        [HttpPut("{id}")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(string), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(string), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Put([FromRoute] Guid id, [FromBody] TUpdateCommand command)
        {
            command.Id = id;
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(string), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(string), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete([FromRoute] Guid id, [FromBody] TDeleteCommand command)
        {
            command.Id = id;
            await _mediator.Send(command);
            return NoContent();
        }
    }
}