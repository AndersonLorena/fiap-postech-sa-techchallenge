using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.ValueObjects;

namespace AL.Fiap.PosTech.TechChallenge.Domain.Entities
{
    public partial class UserEntity : BaseEntity
    {
        public string Name { get; set; } = null!;

        public string Nickname { get; set; } = null!;

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;

        public virtual CpfValueObject? Cpf { get; set; }

        public new int? CreatedById { get; set; }
    }
}