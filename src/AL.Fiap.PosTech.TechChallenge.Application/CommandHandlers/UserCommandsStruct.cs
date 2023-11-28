using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using AL.Fiap.PosTech.TechChallenge.Ports.Helpers;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;
using FluentValidation;

namespace AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers
{
    public class CreateUserCommandsHandler : CreateCommandBaseHandler<CreateUserCommand, UserEntity>
    {
        private readonly IHashHelper<UserStructureToHash> _hashHelper;

        public CreateUserCommandsHandler(
            IPersistenceRepository<UserEntity> persistenceRepository,
            IHashHelper<UserStructureToHash> hashHelper,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        {
            _hashHelper = hashHelper;
        }

        public override async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            request.Password = _hashHelper.HashPassword(_mapper.Map<UserStructureToHash>(request), request.Password);
            return await base.Handle(request, cancellationToken);
        }
    }

    public sealed class UpdateUserCommandsHandler : UpdateCommandBaseHandler<UpdateUserCommand, UserEntity>
    {
        public UpdateUserCommandsHandler(
            IPersistenceRepository<UserEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class DeleteUserCommandsHandler : DeleteCommandBaseHandler<DeleteUserCommand, UserEntity>
    {
        public DeleteUserCommandsHandler(
            IPersistenceRepository<UserEntity> persistenceRepository,
            IQueryRepository<UserEntity> queryRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                queryRepository,
                mapper)
        { }
    }

    public sealed class UserStructureToHash
    {
        public string Name { get; set; } = null!;

        public string Nickname { get; set; } = null!;

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;
    }

    public sealed class CreateUserCommand : CreateCommandBase
    {
        public string Name { get; set; } = null!;

        public string Nickname { get; set; } = null!;

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;

        public new int? CreatedById { get; set; }
    }

    public sealed class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
        }
    }

    public sealed class UpdateUserCommand : UpdateCommandBase
    {
        public string Name { get; set; } = null!;

        public string Nickname { get; set; } = null!;

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;
    }

    public sealed class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserCommandValidator()
        {
        }
    }

    public sealed class DeleteUserCommand : DeleteCommandBase
    {
    }

    public sealed class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
    {
        public DeleteUserCommandValidator()
        {
        }
    }
}