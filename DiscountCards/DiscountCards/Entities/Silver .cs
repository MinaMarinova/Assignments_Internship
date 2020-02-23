namespace DiscountCards.Entities
{
    public class Silver : Card
    {
        private const double initialDiscount = 2;
        private const double maxDiscount = 3.5;

        public Silver(decimal turnover)
            : base(turnover)
        {
        }

        public override double DiscountRate
        {
            get
            {
                if (this.Turnover > 300)
                {
                    return maxDiscount;
                }

                return initialDiscount;
            }
        }
    }
}
