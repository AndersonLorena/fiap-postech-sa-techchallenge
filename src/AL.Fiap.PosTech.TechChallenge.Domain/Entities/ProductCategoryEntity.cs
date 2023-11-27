using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;

namespace AL.Fiap.PosTech.TechChallenge.Domain.Entities
{
    public partial class ProductCategoryEntity : BaseEntity
    {
        public string Name { get; set; } = null!;

        public virtual ICollection<ProductEntity> Products { get; set; } = new List<ProductEntity>();
    }
}