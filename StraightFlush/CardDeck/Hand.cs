using System;
using System.Collections.Generic;

namespace StraightFlush
{
    public class Hand
    {
        public List<Card> cardsInHand;

        public Hand(List<Card> cardsInHand)
        {
            this.cardsInHand = cardsInHand;
        }

        public void PrintHand(List<Card> cardsInHand)
        {
            foreach (Card card in cardsInHand)
            {
                Console.WriteLine($"{card.Suite} - {card.NamedValue}");
            }
        }
    }
}
