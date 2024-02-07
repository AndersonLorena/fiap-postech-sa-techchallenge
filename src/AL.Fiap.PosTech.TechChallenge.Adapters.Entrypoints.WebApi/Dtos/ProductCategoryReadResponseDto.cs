using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos.Base;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos
{
    public partial class ProductCategoryReadResponseDto : BaseReadResponseDto
    {
        public string Name { get; set; } = null!;
    }
}