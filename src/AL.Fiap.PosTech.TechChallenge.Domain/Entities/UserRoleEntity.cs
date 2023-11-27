using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;

namespace AL.Fiap.PosTech.TechChallenge.Domain.Entities
{
    public partial class UserRoleEntity : BaseEntity
    {
        public int UserId { get; set; }

        public virtual UserEntity? User { get; set; }

        public int RoleId { get; set; }

        public virtual RoleEntity? Role { get; set; }
    }
}