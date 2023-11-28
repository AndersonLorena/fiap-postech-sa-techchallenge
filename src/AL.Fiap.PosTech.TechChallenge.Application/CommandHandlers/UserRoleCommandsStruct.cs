using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;
using FluentValidation;

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

    public sealed class CreateUserRoleCommand : CreateCommandBase
    {
        public int? UserId { get; set; }

        public int? RoleId { get; set; }
    }

    public sealed class CreateUserRoleCommandValidator : AbstractValidator<CreateUserRoleCommand>
    {
        public CreateUserRoleCommandValidator()
        {
        }
    }

    public sealed class UpdateUserRoleCommand : UpdateCommandBase
    {
        public int? UserId { get; set; }

        public int? RoleId { get; set; }
    }

    public sealed class UpdateUserRoleCommandValidator : AbstractValidator<UpdateUserRoleCommand>
    {
        public UpdateUserRoleCommandValidator()
        {
        }
    }

    public sealed class DeleteUserRoleCommand : DeleteCommandBase
    {
    }

    public sealed class DeleteUserRoleCommandValidator : AbstractValidator<DeleteUserRoleCommand>
    {
        public DeleteUserRoleCommandValidator()
        {
        }
    }
}