namespace InvestBack.ArquiteturaFIAP.Core.Entities
{
    /// <summary>
    /// Entidade da criptomoeda
    /// </summary>
    public class Cryptocurrency : Entity
    {
        /// <summary>
        /// Sigla da criptomoeda
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// Nome da criptomoeda
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Quantidade
        /// </summary>
        public int Quantity { get; set; }

        public IEnumerable<Transaction> Transactions { get; set; } 

        public override bool IsValid()
        {
            return true;
        }
    }
}
