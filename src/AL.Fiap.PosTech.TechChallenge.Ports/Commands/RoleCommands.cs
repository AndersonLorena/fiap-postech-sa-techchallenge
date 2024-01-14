using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using FluentValidation;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Commands
{
    public sealed class CreateRoleCommand : CreateCommandBase
    {
        public string Name { get; set; } = null!;

        public int? RoleTypeId { get; set; }

        public string ImgUrl { get; set; } = null!;
    }

    public sealed class CreateRoleCommandValidator : AbstractValidator<CreateRoleCommand>
    {
        public CreateRoleCommandValidator()
        {
        }
    }

    public sealed class UpdateRoleCommand : UpdateCommandBase
    {
        public string Name { get; set; } = null!;

        public int? RoleTypeId { get; set; }

        public string ImgUrl { get; set; } = null!;
    }

    public sealed class UpdateRoleCommandValidator : AbstractValidator<UpdateRoleCommand>
    {
        public UpdateRoleCommandValidator()
        {
        }
    }

    public sealed class DeleteRoleCommand : DeleteCommandBase
    {
    }

    public sealed class DeleteRoleCommandValidator : AbstractValidator<DeleteRoleCommand>
    {
        public DeleteRoleCommandValidator()
        {
        }
    }
}