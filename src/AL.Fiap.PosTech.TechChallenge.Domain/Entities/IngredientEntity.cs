using AL.Fiap.PosTech.TechChallenge.Domain.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;

namespace AL.Fiap.PosTech.TechChallenge.Domain.Entities
{
    public partial class IngredientEntity : BaseEntity, IEntity
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public virtual ICollection<ProductIngredientEntity> ProductIngredients { get; set; } = new List<ProductIngredientEntity>();

        public virtual ICollection<OrderItemIngredientEntity> OrderItemIngredients { get; set; } = new List<OrderItemIngredientEntity>();
    }
}