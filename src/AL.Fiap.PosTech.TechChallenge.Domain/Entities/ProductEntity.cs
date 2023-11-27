using AL.Fiap.PosTech.TechChallenge.Domain.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;

namespace AL.Fiap.PosTech.TechChallenge.Domain.Entities
{
    public partial class ProductEntity : BaseEntity, IEntity, IAggregateRoot
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public int ProductCategoryId { get; set; }

        public virtual ProductCategoryEntity? ProductCategory { get; set; }

        public virtual ICollection<ProductIngredientEntity> ProductIngredients { get; set; } = new List<ProductIngredientEntity>();

        public virtual ICollection<OrderItemEntity> OrderItems { get; set; } = new List<OrderItemEntity>();
    }
}