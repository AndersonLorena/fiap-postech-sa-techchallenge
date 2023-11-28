using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;
using FluentValidation;

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

    public sealed class CreateIngredientCommand : CreateCommandBase
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }
    }

    public sealed class CreateIngredientCommandValidator : AbstractValidator<CreateIngredientCommand>
    {
        public CreateIngredientCommandValidator()
        {
        }
    }

    public sealed class UpdateIngredientCommand : UpdateCommandBase
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }
    }

    public sealed class UpdateIngredientCommandValidator : AbstractValidator<UpdateIngredientCommand>
    {
        public UpdateIngredientCommandValidator()
        {
        }
    }

    public sealed class DeleteIngredientCommand : DeleteCommandBase
    {
    }

    public sealed class DeleteIngredientCommandValidator : AbstractValidator<DeleteIngredientCommand>
    {
        public DeleteIngredientCommandValidator()
        {
        }
    }
}