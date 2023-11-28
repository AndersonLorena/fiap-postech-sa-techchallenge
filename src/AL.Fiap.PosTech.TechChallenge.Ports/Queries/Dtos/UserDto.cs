using AL.Fiap.PosTech.TechChallenge.Domain.ValueObjects;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos.Base;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos
{
    public partial class UserDto : BaseDto
    {
        public string Name { get; set; } = null!;

        public string Nickname { get; set; } = null!;

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;

        public virtual CpfValueObject? Cpf { get; set; }

        public new int? CreatedById { get; set; }
    }
} 