using System;
using System.Linq;
using System.Reflection;

namespace DiscountCards.Entities
{
    public class CardFactory
    {
        public Card CreateCard(string type, decimal turnover)
        {
            var typeCard = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == type);

            if (typeCard == null)
            {
                throw new Exception("There is no such a card in the system!");
            }
            var instanceCard = Activator.CreateInstance(typeCard, turnover);

            return (Card)instanceCard;
        }
    }
}

