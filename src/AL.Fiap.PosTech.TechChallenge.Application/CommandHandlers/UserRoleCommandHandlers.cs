using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;

namespace AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers
{
    public sealed class CreateUserRoleCommandsHandler : CreateCommandBaseHandler<CreateUserRoleCommand, UserRoleEntity>
    {
        public CreateUserRoleCommandsHandler(
            IPersistenceRepository<UserRoleEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class UpdateUserRoleCommandsHandler : UpdateCommandBaseHandler<UpdateUserRoleCommand, UserRoleEntity>
    {
        public UpdateUserRoleCommandsHandler(
            IPersistenceRepository<UserRoleEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class DeleteUserRoleCommandsHandler : DeleteCommandBaseHandler<DeleteUserRoleCommand, UserRoleEntity>
    {
        public DeleteUserRoleCommandsHandler(
            IPersistenceRepository<UserRoleEntity> persistenceRepository,
            IQueryRepository<UserRoleEntity> queryRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                queryRepository,
                mapper)
        { }
    }
}