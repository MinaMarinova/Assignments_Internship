using System;
using System.Text;

namespace DiscountCards
{
    public class PayDesk
    {
        private static decimal GetDiscount(double discountRate, decimal purchaseValue)
        {
            if (purchaseValue < 0)
            {
                throw new Exception("The purchase value must be a positive number!");
            }
            return purchaseValue * (decimal)(discountRate / 100);
        }

        private static decimal GetTotalValue(double discountRate, decimal purchaseValue)
        {
            return purchaseValue - GetDiscount(discountRate, purchaseValue);
        }

        public static string GetOutput(decimal purchaseValue, double discountRate)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine($"Purchase value: ${purchaseValue:F2}");
            sb.AppendLine();
            sb.AppendLine($"Discount rate: {discountRate:F1}%");
            sb.AppendLine();
            sb.AppendLine($"Discount: ${GetDiscount(discountRate, purchaseValue):F2}");
            sb.AppendLine();
            sb.AppendLine($"Total: ${GetTotalValue(discountRate, purchaseValue):F2}");

            return sb.ToString().TrimEnd();
        }
    }
}
