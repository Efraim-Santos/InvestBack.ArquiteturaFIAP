namespace InvestBack.ArquiteturaFIAP.Core.Entities
{
    public class Wallet : Entity
    {
        public string Name { get; set; }

        public IEnumerable<Transaction> TransactionsWallet { get; set; }

        public override bool IsValid()
        {
            return true;
        }
    }
}
