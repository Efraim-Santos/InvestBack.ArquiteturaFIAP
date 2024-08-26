using InvestBack.ArquiteturaFIAP.Core.Entities;
using InvestBack.ArquiteturaFIAP.Infrastructure.Interfaces;
using MongoDB.Driver;

namespace InvestBack.ArquiteturaFIAP.Infrastructure.Repositories
{
    public class WalletRepository : Repository<Wallet>, IWallerRepository
    {
        public WalletRepository(IMongoClient mongoClient) : base(mongoClient)
        {
                
        }
    }
}
