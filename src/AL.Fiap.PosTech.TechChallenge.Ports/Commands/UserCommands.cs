using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using FluentValidation;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Commands
{
    public sealed class CreateUserCommand : CreateCommandBase<UserEntity>
    {
        public string Name { get; set; } = null!;

        public string Nickname { get; set; } = null!;

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;
    }

    public sealed class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
        }
    }

    public sealed class UpdateUserCommand : UpdateCommandBase<UserEntity>
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