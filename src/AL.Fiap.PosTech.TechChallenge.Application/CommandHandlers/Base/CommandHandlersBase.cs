﻿using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
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
            await _persistenceRepository.AddAsync(entity);

            return entity;
        }
    }

    public abstract class ReadCommandBaseHandler<TReadCommand, TReadCommandResponse, TEntity> :
        IRequestHandler<TReadCommand, TReadCommandResponse>
        where TReadCommand : IRequest<TReadCommandResponse>
        where TReadCommandResponse : ReadCommandResponseBase
        where TEntity : BaseEntity
    {
        protected readonly IQueryRepository<TEntity> _queryRepository;
        protected readonly IMapper _mapper;

        public ReadCommandBaseHandler(
            IQueryRepository<TEntity> queryRepository,
            IMapper mapper)
        {
            _queryRepository = queryRepository;
            _mapper = mapper;
        }

        public virtual async Task<TReadCommandResponse> Handle(TReadCommand request, CancellationToken cancellationToken)
        {
            var result = await _queryRepository.GetAllAsync();
            return _mapper.Map<TReadCommandResponse>(result);
        }
    }

    public abstract class UpdateCommandBaseHandler<TUpdateCommand, TEntity> :
        IRequestHandler<TUpdateCommand, BaseEntity>
        where TUpdateCommand : UpdateCommandBase
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

        public virtual async Task<BaseEntity> Handle(TUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<TEntity>(request);
            await _persistenceRepository.UpdateAsync(entity);

            return entity;
        }
    }

    public abstract class DeleteCommandBaseHandler<TDeleteCommand, TEntity> :
        IRequestHandler<TDeleteCommand>
        where TDeleteCommand : DeleteCommandBase
        where TEntity : BaseEntity
    {
        protected readonly IPersistenceRepository<TEntity> _persistenceRepository;
        protected readonly IQueryRepository<TEntity> _queryRepository;
        protected readonly IMapper _mapper;

        protected DeleteCommandBaseHandler(
            IPersistenceRepository<TEntity> persistenceRepository,
            IQueryRepository<TEntity> queryRepository,
            IMapper mapper)
        {
            _persistenceRepository = persistenceRepository;
            _queryRepository = queryRepository;
            _mapper = mapper;
        }

        public virtual async Task Handle(TDeleteCommand request, CancellationToken cancellationToken)
        {
            var dto = await _queryRepository.GetByIdAsync(request.Id);
            await _persistenceRepository.DeleteAsync(dto);
        }
    }
}