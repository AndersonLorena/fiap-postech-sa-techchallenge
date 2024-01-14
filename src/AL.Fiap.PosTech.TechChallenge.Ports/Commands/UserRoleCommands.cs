using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using FluentValidation;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Commands
{
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