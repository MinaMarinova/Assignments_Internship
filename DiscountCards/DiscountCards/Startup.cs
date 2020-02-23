using DiscountCards.Entities;
using System;

namespace DiscountCards
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var cardFactory = new CardFactory();
            
            string input = Console.ReadLine();

            try
            {
                string[] inputParams = input.Split(new [] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (inputParams.Length != 3)
                {
                    throw new Exception("The input must consist of card type, turnover and purchase value!");
                }
                string typeCard = inputParams[0];
                decimal turnover = decimal.Parse(inputParams[1]);
                decimal purchaseValue = decimal.Parse(inputParams[2]);

                Card card = cardFactory.CreateCard(typeCard, turnover);
                var discountRate = card.DiscountRate;
                
                Console.WriteLine(PayDesk.GetOutput(purchaseValue, discountRate));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
