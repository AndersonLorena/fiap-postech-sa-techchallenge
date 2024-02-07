namespace AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual Guid CreatedById { get; set; }

        public virtual UserEntity? CreatedBy { get; set; } = null!;

        public DateTime? UpdatedAt { get; set; }

        public virtual Guid UpdatedById { get; set; }

        public virtual UserEntity? UpdatedBy { get; set; }

        public BaseEntity()
        {
        }

        public BaseEntity(UserEntity createdBy)
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            CreatedBy = createdBy;
        }

        public BaseEntity(Guid id, UserEntity updatedBy)
        {
            Id = id;
            UpdatedAt = updatedBy.UpdatedAt;
            UpdatedById = updatedBy.Id;
            UpdatedBy = updatedBy;
        }

        protected void ChangeUpdate()
        {

        }
    }
}