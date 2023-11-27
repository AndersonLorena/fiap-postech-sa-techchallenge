using AL.Fiap.PosTech.TechChallenge.Domain.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;

namespace AL.Fiap.PosTech.TechChallenge.Domain.Entities
{
    public partial class ProductIngredientEntity : BaseEntity, IEntity, IAggregate
    {
        public int ProductId { get; set; }

        public virtual ProductEntity? Product { get; set; }

        public int IngredientId { get; set; }

        public virtual IngredientEntity? Ingredient { get; set; }
    }
}