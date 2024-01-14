using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;

namespace AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers
{
    public class CreateRoleCommandsHandler : CreateCommandBaseHandler<CreateRoleCommand, RoleEntity>
    {
        public CreateRoleCommandsHandler(
            IPersistenceRepository<RoleEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class UpdateRoleCommandsHandler : UpdateCommandBaseHandler<UpdateRoleCommand, RoleEntity>
    {
        public UpdateRoleCommandsHandler(
            IPersistenceRepository<RoleEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class DeleteRoleCommandsHandler : DeleteCommandBaseHandler<DeleteRoleCommand, RoleEntity>
    {
        public DeleteRoleCommandsHandler(
            IPersistenceRepository<RoleEntity> persistenceRepository,
            IQueryRepository<RoleEntity> queryRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                queryRepository,
                mapper)
        { }
    }
}