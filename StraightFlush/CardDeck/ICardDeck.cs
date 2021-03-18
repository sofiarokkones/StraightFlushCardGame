using System;
using System.Collections.Generic;

namespace StraightFlush
{
    public interface ICardDeck
    {
        void Shuffle();
        List<Card> DrawCards(int i);
    }
}
