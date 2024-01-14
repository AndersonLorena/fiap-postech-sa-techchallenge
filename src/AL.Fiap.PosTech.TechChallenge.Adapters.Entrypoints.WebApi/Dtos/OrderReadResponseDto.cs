using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos.Base;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos
{
    public partial class OrderReadResponseDto : BaseReadResponseDto
    {
        public int OrderStatusId { get; set; }

        public virtual OrderStatusReadResponseDto? OrderStatus { get; set; }

        public decimal TotalAmount { get; set; }

        public virtual ICollection<OrderItemReadResponseDto> OrderItems { get; set; } = new List<OrderItemReadResponseDto>();
    }
}