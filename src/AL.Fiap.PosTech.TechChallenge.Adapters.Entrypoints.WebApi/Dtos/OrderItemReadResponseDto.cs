using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos.Base;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos
{
    public partial class OrderItemReadResponseDto : BaseReadResponseDto
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public virtual ProductReadResponseDto? Product { get; set; }

        public decimal ItemPrice { get; set; }

        public virtual ICollection<OrderItemIngredientReadResponseDto> OrderItemIngredients { get; set; } = new List<OrderItemIngredientReadResponseDto>();
    }
}