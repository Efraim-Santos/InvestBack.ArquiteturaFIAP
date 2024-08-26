using InvestBack.ArquiteturaFIAP.Api.Service.Requests;
using InvestBack.ArquiteturaFIAP.Core.Entities;
using InvestBack.ArquiteturaFIAP.Infrastructure.Interfaces;
using InvestBack.ArquiteturaFIAP.Service.Interfaces;

namespace InvestBack.ArquiteturaFIAP.Service.Services
{
    public class WalletService : IWalletService
    {
        private readonly IWallerRepository _repository;

        public WalletService(IWallerRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateWalletAsync(WalletRequest wallet)
        {
            var walletEntity = new Wallet   
            {
                Name = wallet.Nome,
                TransactionsWallet = null
            };

            await _repository.Add(walletEntity);
        }

        public Task UpdateWalletAsync(WalletRequest wallet)
        {
            throw new NotImplementedException();
        }
    }
}
