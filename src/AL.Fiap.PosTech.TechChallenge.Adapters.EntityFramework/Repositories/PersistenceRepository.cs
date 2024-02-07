using AL.Fiap.PosTech.TechChallenge.Adapters.EntityFramework.DbContexts;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.EntityFramework.Repositories
{
    public class PersistenceRepository<TEntity> : IPersistenceRepository<TEntity> 
        where TEntity : BaseEntity
    {
        public virtual async Task AddAsync(TEntity entity)
        {
            using (var context = new TechChallengeDbContext())
            {
                await context.AddAsync(entity);
                await context.SaveChangesAsync();
            }
        }

        public virtual async Task DeleteAsync(TEntity entity)
        {
            using (var context = new TechChallengeDbContext())
            {
                context.Attach<TEntity>(entity);
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }

        public Task<TEntity> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            using (var context = new TechChallengeDbContext())
            {
                if (context.Entry(entity).State == EntityState.Detached)
                    context.Attach<TEntity>(entity);

                context.Remove<TEntity>(entity);
                await context.SaveChangesAsync();
            }
        }
    }
}