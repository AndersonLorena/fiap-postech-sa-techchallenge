using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;
using FluentValidation;

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

    public sealed class CreateRoleCommand : CreateCommandBase
    {
        public string Name { get; set; } = null!;

        public int? RoleTypeId { get; set; }

        public string ImgUrl { get; set; } = null!;
    }

    public sealed class CreateRoleCommandValidator : AbstractValidator<CreateRoleCommand>
    {
        public CreateRoleCommandValidator()
        {
        }
    }

    public sealed class UpdateRoleCommand : UpdateCommandBase
    {
        public string Name { get; set; } = null!;

        public int? RoleTypeId { get; set; }

        public string ImgUrl { get; set; } = null!;
    }

    public sealed class UpdateRoleCommandValidator : AbstractValidator<UpdateRoleCommand>
    {
        public UpdateRoleCommandValidator()
        {
        }
    }

    public sealed class DeleteRoleCommand : DeleteCommandBase
    {
    }

    public sealed class DeleteRoleCommandValidator : AbstractValidator<DeleteRoleCommand>
    {
        public DeleteRoleCommandValidator()
        {
        }
    }
}