namespace DiscountCards.Entities
{
    public abstract class Card
    {
        protected Card(decimal turnover)
        {
            this.Turnover = turnover;
        }

        public string Owner { get; set; }

        protected decimal Turnover { get; }

        public abstract double DiscountRate { get; }

    }
}
