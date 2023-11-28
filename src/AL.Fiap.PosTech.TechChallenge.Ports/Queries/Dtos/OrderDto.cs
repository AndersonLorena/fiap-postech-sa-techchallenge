using AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos.Base;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos
{
    public partial class OrderDto : BaseDto
    {
        public int OrderStatusId { get; set; }

        public virtual OrderStatusDto? OrderStatus { get; set; }

        public decimal TotalAmount { get; set; }

        public virtual ICollection<OrderItemDto> OrderItems { get; set; } = new List<OrderItemDto>();
    }
}