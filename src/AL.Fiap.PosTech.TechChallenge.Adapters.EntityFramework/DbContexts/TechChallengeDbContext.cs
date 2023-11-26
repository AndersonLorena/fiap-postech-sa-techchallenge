using Microsoft.EntityFrameworkCore;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.EntityFramework.DbContexts
{
    public partial class TechChallengeDbContext : DbContext
    {
        public TechChallengeDbContext()
        {
        }

        public TechChallengeDbContext(DbContextOptions<TechChallengeDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=127.0.0.1;Database=dev-al-fiap-postech-techchallenge;User Id=sa;Password=AF@Sql01;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AI");
        }
    }
}