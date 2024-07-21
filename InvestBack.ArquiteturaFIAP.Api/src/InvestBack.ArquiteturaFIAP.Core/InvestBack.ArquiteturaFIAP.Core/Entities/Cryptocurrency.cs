namespace InvestBack.ArquiteturaFIAP.Core.Entities
{
    public class Cryptocurrency : Entity
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public override bool IsValid()
        {
            return true;
        }
    }
}
