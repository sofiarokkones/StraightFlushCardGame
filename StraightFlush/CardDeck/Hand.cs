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
    }
}
