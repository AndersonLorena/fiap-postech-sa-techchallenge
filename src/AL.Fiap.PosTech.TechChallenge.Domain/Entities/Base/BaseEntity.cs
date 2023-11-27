namespace AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual int CreatedById { get; set; }

        public virtual UserEntity CreatedBy { get; set; } = null!;

        public DateTime? UpdatedAt { get; set; }

        public virtual int? UpdatedById { get; set; }

        public virtual UserEntity? UpdatedBy { get; set; }
    }
}