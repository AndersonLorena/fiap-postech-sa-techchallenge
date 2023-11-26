using AL.Fiap.PosTech.TechChallenge.Adapters.EntityFramework.DbContexts;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.EntityFramework.Repositories
{
    public class PersistenceRepository<T> : IPersistenceRepository<T> where T : BaseEntity
    {
        public virtual async Task AddAsync(T entity)
        {
            using (var context = new TechChallengeDbContext())
            {
                await context.AddAsync(entity);
                await context.SaveChangesAsync();
            }
        }

        public virtual async Task DeleteAsync(T entity)
        {
            using (var context = new TechChallengeDbContext())
            {
                context.Attach<T>(entity);
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }

        public virtual async Task UpdateAsync(T entity)
        {
            using (var context = new TechChallengeDbContext())
            {
                if (context.Entry(entity).State == EntityState.Detached)
                    context.Attach<T>(entity);

                context.Remove<T>(entity);
                await context.SaveChangesAsync();
            }
        }
    }
}