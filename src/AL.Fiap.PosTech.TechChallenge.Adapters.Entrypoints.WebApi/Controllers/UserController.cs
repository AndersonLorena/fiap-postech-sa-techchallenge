using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Controllers.Base;
using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands;
using AL.Fiap.PosTech.TechChallenge.Ports.Interfaces.Queries;
using AutoMapper;
using MediatR;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Controllers
{
    public sealed class UserController : CrudBaseController<
        CreateUserCommand,
        UserReadResponseDto,
        UpdateUserCommand,
        DeleteUserCommand,
        UserEntity>
    {
        public UserController(
            ISender mediator,
            IQueryRepository<UserEntity> queryRepository,
            IMapper mapper)
            : base(
                  mediator,
                  queryRepository,
                  mapper)
        {
        }
    }
}