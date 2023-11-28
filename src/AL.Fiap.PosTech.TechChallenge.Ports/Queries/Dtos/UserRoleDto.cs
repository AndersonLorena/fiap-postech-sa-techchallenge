using AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos.Base;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos
{
    public partial class UserRoleDto : BaseDto
    {
        public int UserId { get; set; }

        public int RoleId { get; set; }

        public virtual RoleDto? Role { get; set; }
    }
}