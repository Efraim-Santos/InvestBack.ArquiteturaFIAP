using InvestBack.ArquiteturaFIAP.Core.Entities;

namespace InvestBack.ArquiteturaFIAP.Infrastructure.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task Add(TEntity entity);

        Task UpdateAsync(Guid id, TEntity entity);

        Task<TEntity> GetById(Guid id);

        Task<List<TEntity>> GetAll();

        Task Remove(TEntity entity);
    }
}
