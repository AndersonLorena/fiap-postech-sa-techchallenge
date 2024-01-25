using AL.Fiap.PosTech.TechChallenge.Adapters.EntityFramework.DbContexts;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;
using AL.Fiap.PosTech.TechChallenge.Ports.Interfaces.Queries;
using Microsoft.EntityFrameworkCore;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.EntityFramework.Queries
{
    public class QueryRepository<T> : IQueryRepository<T> where T : BaseEntity
    {
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            using (var context = new TechChallengeDbContext())
            {
                return await context.Set<T>().ToListAsync();
            }
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            using (var context = new TechChallengeDbContext())
            {
                return await context.Set<T>().FindAsync(id);
            }
        }
    }
}