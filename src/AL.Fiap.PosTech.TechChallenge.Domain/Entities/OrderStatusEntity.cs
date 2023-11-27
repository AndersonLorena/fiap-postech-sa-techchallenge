using AL.Fiap.PosTech.TechChallenge.Domain.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;

namespace AL.Fiap.PosTech.TechChallenge.Domain.Entities
{
    public partial class OrderStatusEntity : BaseEntity, IEntity
    {
        public string Name { get; set; } = null!;

        public virtual ICollection<OrderEntity> Orders { get; set; } = new List<OrderEntity>();
    }
}