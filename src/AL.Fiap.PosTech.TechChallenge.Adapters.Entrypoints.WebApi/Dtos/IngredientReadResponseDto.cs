using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos.Base;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos
{
    public partial class IngredientReadResponseDto : BaseReadResponseDto
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }
    }
}