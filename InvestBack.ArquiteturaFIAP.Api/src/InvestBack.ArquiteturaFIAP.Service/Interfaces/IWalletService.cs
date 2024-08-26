using InvestBack.ArquiteturaFIAP.Api.Service.Requests;

namespace InvestBack.ArquiteturaFIAP.Service.Interfaces
{
    public interface IWalletService
    {
        public Task CreateWalletAsync(WalletRequest wallet);
        public Task UpdateWalletAsync(WalletRequest wallet);
    }
}
