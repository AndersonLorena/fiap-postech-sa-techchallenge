using AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos.Base;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos
{
    public partial class ProductCategoryDto : BaseDto
    {
        public string Name { get; set; } = null!;
    }
}