using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos.Base;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos
{
    public partial class ProductReadResponseDto : BaseReadResponseDto
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public int ProductCategoryId { get; set; }

        public virtual ProductCategoryReadResponseDto? ProductCategory { get; set; }

        public virtual ICollection<ProductIngredientReadResponseDto> ProductIngredients { get; set; } = new List<ProductIngredientReadResponseDto>();
    }
}