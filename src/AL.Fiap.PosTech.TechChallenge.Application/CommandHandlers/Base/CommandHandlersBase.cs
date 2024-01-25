using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using AutoMapper;
using MediatR;

namespace AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base
{
    public abstract class CreateCommandBaseHandler<TCreateCommand, TEntity> :
        IRequestHandler<TCreateCommand, TEntity>
        where TCreateCommand : CreateCommandBase<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly IPersistenceRepository<TEntity> _persistenceRepository;
        protected readonly IMapper _mapper;

        public CreateCommandBaseHandler(
            IPersistenceRepository<TEntity> persistenceRepository,
            IMapper mapper)
        {
            _persistenceRepository = persistenceRepository;
            _mapper = mapper;
        }

        public virtual async Task<TEntity> Handle(TCreateCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<TEntity>(request);
            await _persistenceRepository.SaveAsync(entity);

            return entity;
        }
    }

    public abstract class UpdateCommandBaseHandler<TUpdateCommand, TEntity> :
        IRequestHandler<TUpdateCommand, TEntity>
        where TUpdateCommand : UpdateCommandBase<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly IPersistenceRepository<TEntity> _persistenceRepository;
        protected readonly IMapper _mapper;

        public UpdateCommandBaseHandler(
            IPersistenceRepository<TEntity> persistenceRepository,
            IMapper mapper)
        {
            _persistenceRepository = persistenceRepository;
            _mapper = mapper;
        }

        public virtual async Task<TEntity> Handle(TUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<TEntity>(request);
            await _persistenceRepository.SaveAsync(entity);

            return entity;
        }
    }

    public abstract class DeleteCommandBaseHandler<TDeleteCommand, TEntity> :
        IRequestHandler<TDeleteCommand>
        where TDeleteCommand : DeleteCommandBase
        where TEntity : BaseEntity
    {
        protected readonly IPersistenceRepository<TEntity> _persistenceRepository;
        protected readonly IMapper _mapper;

        protected DeleteCommandBaseHandler(
            IPersistenceRepository<TEntity> persistenceRepository,
            IMapper mapper)
        {
            _persistenceRepository = persistenceRepository;
            _mapper = mapper;
        }

        public virtual async Task Handle(TDeleteCommand request, CancellationToken cancellationToken)
        {
            var entity = await _persistenceRepository.GetAsync(request.Id);
            await _persistenceRepository.DeleteAsync(entity);
        }
    }
}