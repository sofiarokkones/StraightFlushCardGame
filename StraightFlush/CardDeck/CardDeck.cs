using System;
using System.Collections.Generic;
using System.Linq;

namespace StraightFlush
{
    public class CardDeck : ICardDeck
    {
        public List<Card> Cards { get; private set; }

        public CardDeck()
        {
            Cards = new List<Card>();
            foreach (Card.Suites suite in Enum.GetValues(typeof(Card.Suites)))
            {
                for (int i = 1; i < 14; i++)
                {
                    Cards.Add(new Card()
                    {
                        Suite = suite,
                        Value = i
                    });
                }
            }
        }

        public void Shuffle()
        {
            Cards = Cards.OrderBy(x => Guid.NewGuid()).ToList();
        }

        public List<Card> DrawCards(int nbrCards)
        {
            return Cards.Take(nbrCards).ToList();
        }
    }
}
