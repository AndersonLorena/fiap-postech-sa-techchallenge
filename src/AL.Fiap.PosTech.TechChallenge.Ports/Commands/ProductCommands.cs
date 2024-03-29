﻿using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using FluentValidation;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Commands
{
    public sealed class CreateProductCommand : CreateCommandBase<ProductEntity>
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImgUrl { get; set; } = null!;

        public decimal Price { get; set; }

        public Guid ProductCategoryId { get; set; }

        public IEnumerable<Guid> Ingredients { get; set; } = new List<Guid>();
    }

    public sealed class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
        }
    }

    public sealed class UpdateProductCommand : UpdateCommandBase<ProductEntity>
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImgUrl { get; set; } = null!;

        public decimal Price { get; set; }

        public Guid ProductCategoryId { get; set; }

        public IEnumerable<Guid> Ingredients { get; set; } = new List<Guid>();
    }

    public sealed class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
        }
    }

    public sealed class DeleteProductCommand : DeleteCommandBase
    {
    }

    public sealed class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
    {
        public DeleteProductCommandValidator()
        {
        }
    }
}