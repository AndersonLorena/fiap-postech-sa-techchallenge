using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands;
using AL.Fiap.PosTech.TechChallenge.Ports.Interfaces.Queries;
using AL.Fiap.PosTech.TechChallenge.Ports.Interfaces.Services;
using AutoMapper;

namespace AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers
{
    public class CreateUserCommandsHandler : CreateCommandBaseHandler<CreateUserCommand, UserEntity>
    {
        private readonly IHashService<UserStructureToHash> _hashHelper;

        public CreateUserCommandsHandler(
            IPersistenceRepository<UserEntity> persistenceRepository,
            IHashService<UserStructureToHash> hashHelper,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        {
            _hashHelper = hashHelper;
        }

        public override async Task<UserEntity> Handle(CreateUserCommand request, CancellationToken cancellationToken)
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
}