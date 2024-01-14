using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;

namespace AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers
{
    public class CreateIngredientCommandsHandler : CreateCommandBaseHandler<CreateIngredientCommand, IngredientEntity>
    {
        public CreateIngredientCommandsHandler(
            IPersistenceRepository<IngredientEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class UpdateIngredientCommandsHandler : UpdateCommandBaseHandler<UpdateIngredientCommand, IngredientEntity>
    {
        public UpdateIngredientCommandsHandler(
            IPersistenceRepository<IngredientEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class DeleteIngredientCommandsHandler : DeleteCommandBaseHandler<DeleteIngredientCommand, IngredientEntity>
    {
        public DeleteIngredientCommandsHandler(
            IPersistenceRepository<IngredientEntity> persistenceRepository,
            IQueryRepository<IngredientEntity> queryRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                queryRepository,
                mapper)
        { }
    }
}