using AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos.Base;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos
{
    public partial class ProductIngredientDto : BaseDto
    {
        public int ProductId { get; set; }

        public int IngredientId { get; set; }

        public virtual IngredientDto? Ingredient { get; set; }
    }
}