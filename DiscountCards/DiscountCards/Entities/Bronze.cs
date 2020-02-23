namespace DiscountCards.Entities
{
    public class Bronze : Card
    {
        private const double minDiscount = 0;
        private const double smallDiscount = 1;
        private const double maxDiscount = 2.5;

        public Bronze(decimal turnover) 
            : base(turnover)
        {
        }

        public override double DiscountRate
        {
            get
            {
                if (this.Turnover < 100)
                {
                    return minDiscount;
                }
                else if (this.Turnover >= 100 && this.Turnover <= 300)
                {
                    return smallDiscount;
                }
                else
                {
                    return maxDiscount;
                }
            }
        }
    }
}
