using AL.Fiap.PosTech.TechChallenge.Domain.Entities.Base;

namespace AL.Fiap.PosTech.TechChallenge.Domain.Repositories
{
    public interface IPersistenceRepository<TEntity>
        where TEntity : BaseEntity
    {
        Task SaveAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);

        Task<TEntity> GetAsync(Guid id);
    }
}