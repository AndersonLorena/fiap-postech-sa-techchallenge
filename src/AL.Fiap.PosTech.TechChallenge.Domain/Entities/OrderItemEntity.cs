using AL.Fiap.PosTech.TechChallenge.Domain.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;

namespace AL.Fiap.PosTech.TechChallenge.Domain.Entities
{
    public partial class OrderItemEntity : BaseEntity, IEntity, IAggregate
    {
        public int OrderId { get; set; }

        public virtual OrderEntity? Order { get; set; }

        public int ProductId { get; set; }

        public virtual ProductEntity? Product { get; set; }

        public decimal ItemPrice { get; set; }

        public virtual ICollection<OrderItemIngredientEntity> OrderItemIngredients { get; set; } = new List<OrderItemIngredientEntity>();
    }
}