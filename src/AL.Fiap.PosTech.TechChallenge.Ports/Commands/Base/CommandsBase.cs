using AL.Fiap.PosTech.TechChallenge.Domain.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;
using MediatR;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base
{
    public abstract class CommandBaseAudit
    {
        public Guid PerformedById { get; set; }
    }

    public abstract class CommandBase<TEntity> : CommandBaseAudit, IRequest<TEntity>
    { }

    public abstract class CommandBase : CommandBaseAudit, IRequest
    { }

    public abstract class CreateCommandBase<TEntity> : CommandBase<TEntity>
    { }

    public abstract class UpdateCommandBase<TEntity> : CommandBase<TEntity>
    {
        public Guid Id { get; set; }
    }

    public abstract class DeleteCommandBase : CommandBase
    {
        public Guid Id { get; set; }
    }

    public abstract class ReadCommandBase : IRequest<ReadCommandResponseBase>
    {
        public int? Id { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int? CreatedById { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? UpdatedById { get; set; }
    }

    public abstract class ReadCommandResponseBase
    {
        public int? Id { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int? CreatedById { get; set; }

        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedById { get; set; }
    }
}