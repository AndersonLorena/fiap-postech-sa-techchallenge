using AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos.Base;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos
{
    public partial class ProductDto : BaseDto
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public int ProductCategoryId { get; set; }

        public virtual ProductCategoryDto? ProductCategory { get; set; }

        public virtual ICollection<ProductIngredientDto> ProductIngredients { get; set; } = new List<ProductIngredientDto>();
    }
}