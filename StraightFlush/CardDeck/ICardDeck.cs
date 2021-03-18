using System;
using System.Collections.Generic;

namespace StraightFlush
{
    public interface ICardDeck
    {
        public void Shuffle();

        public List<Card> DrawCards(int i);

    }
}
