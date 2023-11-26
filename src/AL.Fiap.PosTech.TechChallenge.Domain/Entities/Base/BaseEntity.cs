namespace AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual int CreatedById { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? UpdatedById { get; set; }
    }
}