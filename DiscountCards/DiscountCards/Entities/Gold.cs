namespace DiscountCards.Entities
{
    public class Gold : Card
    {
        private const double initialDiscountRate = 2;
        private const double discountLimit = 10;

        public Gold(decimal turnover) 
            : base(turnover)
        {
        }

        public override double DiscountRate 
        {
            get
            {
                int additionalDiscountRate = 0;
                for (int i = 100; i <= Turnover; i+=100)
                {
                    additionalDiscountRate++;
                }

                if (additionalDiscountRate + initialDiscountRate > discountLimit)
                {
                    return discountLimit;
                }

                return additionalDiscountRate + initialDiscountRate;
            }
        }
    }
}
