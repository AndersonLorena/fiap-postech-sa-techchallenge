using MediatR;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base
{
    public abstract class CreateCommandBase : IRequest<int>
    {
        public DateTime CreatedAt { get; set; }

        public virtual int CreatedById { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? UpdatedById { get; set; }
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

    public abstract class UpdateCommandBase : IRequest<int>
    {
        public int Id { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? UpdatedById { get; set; }
    }

    public abstract class DeleteCommandBase : IRequest
    {
        public int Id { get; set; }
    }
}