using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos.Base;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos
{
    public partial class ProductIngredientReadResponseDto : BaseReadResponseDto
    {
        public int ProductId { get; set; }

        public int IngredientId { get; set; }

        public virtual IngredientReadResponseDto? Ingredient { get; set; }
    }
}