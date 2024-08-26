namespace InvestBack.ArquiteturaFIAP.Core.Entities
{
    public class Wallet : Entity
    {
        /// <summary>
        /// Nome da carteira
        /// </summary>
        public string Name { get; set; } = string.Empty;

        public override bool IsValid()
        {
            return true;
        }
    }
}
