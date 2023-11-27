using AL.Fiap.PosTech.TechChallenge.Domain.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;

namespace AL.Fiap.PosTech.TechChallenge.Domain.Entities
{
    public partial class OrderItemIngredientEntity : BaseEntity, IEntity, IAggregate
    {
        public int OrderItemId { get; set; }

        public virtual OrderItemEntity? OrderItem { get; set; }

        public int IngredientId { get; set; }

        public virtual IngredientEntity? Ingredient { get; set; }
    }
}