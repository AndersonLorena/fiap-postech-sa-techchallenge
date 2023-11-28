using AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos.Base;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos
{
    public partial class OrderItemDto : BaseDto
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public virtual ProductDto? Product { get; set; }

        public decimal ItemPrice { get; set; }

        public virtual ICollection<OrderItemIngredientDto> OrderItemIngredients { get; set; } = new List<OrderItemIngredientDto>();
    }
}