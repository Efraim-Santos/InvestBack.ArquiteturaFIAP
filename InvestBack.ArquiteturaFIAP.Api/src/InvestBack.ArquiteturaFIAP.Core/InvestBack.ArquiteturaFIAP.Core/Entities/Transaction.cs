namespace InvestBack.ArquiteturaFIAP.Core.Entities
{
    public class Transaction : Entity
    {
        public Guid WalletId { get; set; }
        public Guid CryptocurrencyId { get; set; }
        public string Currency { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public decimal ContributedAmount { get; set; }
        public decimal BrokerFee { get; set; }
        public decimal Quantity { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal? SalePrice { get; set; }
        public DateTime? SaleDate { get; set; }
        public Wallet Wallet { get; set; }
        public Cryptocurrency Crypto { get; set; }

        public Transaction(string currency, decimal price, DateTime date, decimal contributedAmount, decimal quantity, Wallet wallet, Cryptocurrency crypto)
        {
            Currency = currency;
            Price = price;
            Date = date;
            ContributedAmount = contributedAmount;
            Quantity = quantity;
            Wallet = wallet;
            Crypto = crypto;
        }

        private Transaction()
        { }

        // Método atualizado para edição
        public void Edit(Transaction transaction)
        {
            Wallet = transaction.Wallet;
            Date = transaction.Date;
            Currency = transaction.Currency;
            Quantity = transaction.Quantity;
            TransactionType = transaction.TransactionType;
            BrokerFee = transaction.BrokerFee;
            ContributedAmount = transaction.ContributedAmount;
        }

        // Método para validação
        public override bool IsValid()
        {
            return true;
        }
    }
}
