using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;

namespace AL.Fiap.PosTech.TechChallenge.Domain.Entities
{
    public partial class RoleEntity : BaseEntity
    {
        public string Name { get; set; } = null!;

        public virtual ICollection<UserRoleEntity> UserRoles { get; set; } = new List<UserRoleEntity>();
    }
}