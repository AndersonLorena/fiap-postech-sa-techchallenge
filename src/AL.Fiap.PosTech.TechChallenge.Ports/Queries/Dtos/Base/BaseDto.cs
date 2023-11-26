namespace AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos.Base
{
    public abstract class BaseDto
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual int CreatedById { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? UpdatedById { get; set; }
    }
}