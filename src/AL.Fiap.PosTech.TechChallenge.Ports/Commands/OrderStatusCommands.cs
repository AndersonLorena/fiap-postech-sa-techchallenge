﻿using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using FluentValidation;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Commands
{
    public sealed class CreateOrderStatusCommand : CreateCommandBase<OrderStatusEntity>
    {
        public string Name { get; set; } = null!;
    }

    public sealed class CreateOrderStatusCommandValidator : AbstractValidator<CreateOrderStatusCommand>
    {
        public CreateOrderStatusCommandValidator()
        {
        }
    }

    public sealed class UpdateOrderStatusCommand : UpdateCommandBase<OrderStatusEntity>
    {
        public string Name { get; set; } = null!;
    }

    public sealed class UpdateOrderStatusCommandValidator : AbstractValidator<UpdateOrderStatusCommand>
    {
        public UpdateOrderStatusCommandValidator()
        {
        }
    }

    public sealed class DeleteOrderStatusCommand : DeleteCommandBase
    {
    }

    public sealed class DeleteOrderStatusCommandValidator : AbstractValidator<DeleteOrderStatusCommand>
    {
        public DeleteOrderStatusCommandValidator()
        {
        }
    }
}