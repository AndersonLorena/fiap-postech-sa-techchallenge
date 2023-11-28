using AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos.Base;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos
{
    public partial class OrderItemIngredientDto : BaseDto
    {
        public int OrderItemId { get; set; }

        public int IngredientId { get; set; }

        public virtual IngredientDto? Ingredient { get; set; }
    }
}