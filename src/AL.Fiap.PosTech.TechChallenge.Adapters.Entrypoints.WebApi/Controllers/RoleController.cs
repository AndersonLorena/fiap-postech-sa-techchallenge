using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Controllers.Base;
using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands;
using AL.Fiap.PosTech.TechChallenge.Ports.Interfaces.Queries;
using AutoMapper;
using MediatR;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Controllers
{
    public sealed class RoleController : CrudBaseController<
        CreateRoleCommand,
        RoleReadResponseDto,
        UpdateRoleCommand,
        DeleteRoleCommand,
        RoleEntity>
    {
        public RoleController(
            ISender mediator,
            IQueryRepository<RoleEntity> queryRepository,
            IMapper mapper)
            : base(
                  mediator,
                  queryRepository,
                  mapper)
        {
        }
    }
}