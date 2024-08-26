using InvestBack.ArquiteturaFIAP.Core.Entities;
using InvestBack.ArquiteturaFIAP.Infrastructure.Interfaces;
using MongoDB.Driver;

namespace InvestBack.ArquiteturaFIAP.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly IMongoCollection<TEntity> _collection;

        public Repository(IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase("Investback_db");
            _collection = database.GetCollection<TEntity>(typeof(TEntity).Name.ToLower());
        }

        public async Task Add(TEntity entity)
        {
            entity.DateCreate = DateTime.UtcNow;
            entity.DateOfChange = DateTime.UtcNow;

            await _collection.InsertOneAsync(entity);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await _collection.Find(e => e.Id == id).FirstOrDefaultAsync();
        }

        public async Task Remove(TEntity entity)
        {
            // Assumindo que o tipo Entity tem uma propriedade Id
            await _collection.DeleteOneAsync(e => e.Id == entity.Id);
        }

        public async Task UpdateAsync(Guid id, TEntity entity)
        {
            // Atualiza a propriedade DateOfChange para refletir a data da alteração
            entity.DateOfChange = DateTime.UtcNow;

            // Substitui o documento existente com o mesmo id
            await _collection.ReplaceOneAsync(e => e.Id == id, entity);
        }
    }
}