using AL.Fiap.PosTech.TechChallenge.Domain.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;

namespace AL.Fiap.PosTech.TechChallenge.Domain.Entities
{
    public partial class OrderEntity : BaseEntity, IEntity, IAggregateRoot
    {
        public int OrderStatusId { get; set; }

        public virtual OrderStatusEntity? OrderStatus { get; set; }

        public decimal TotalAmount { get; set; }

        public virtual ICollection<OrderItemEntity> OrderItems { get; set; } = new List<OrderItemEntity>();
    }
}