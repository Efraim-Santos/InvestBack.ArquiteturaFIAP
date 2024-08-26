using InvestBack.ArquiteturaFIAP.Service.Requests;

namespace InvestBack.ArquiteturaFIAP.Api.Service.Requests
{
    public class WalletRequest
    {
        //Adicinar validação dos campos com ValidationResult
        public required string Nome { get; set; }
    }
}
