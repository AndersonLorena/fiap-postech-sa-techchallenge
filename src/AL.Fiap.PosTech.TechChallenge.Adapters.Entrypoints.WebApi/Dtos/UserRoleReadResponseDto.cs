using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos.Base;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos
{
    public partial class UserRoleReadResponseDto : BaseReadResponseDto
    {
        public int UserId { get; set; }

        public int RoleId { get; set; }

        public virtual RoleReadResponseDto? Role { get; set; }
    }
}