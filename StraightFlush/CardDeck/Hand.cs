using System;
using System.Collections.Generic;

namespace StraightFlush
{
    public class Hand
    {
        public List<Card> CardsInHand { get; }

        public Hand(List<Card> cardsInHand)
        {
            CardsInHand = cardsInHand;
        }
    }
}
