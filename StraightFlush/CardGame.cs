using System;
using System.Collections.Generic;
using System.Linq;
namespace StraightFlush
{
    public class CardGame
    {
        private readonly CardDeck _cardDeck;
        private readonly int nbrCardsInHand = 5;
        private Hand hand;

        public CardGame(CardDeck cardDeck)
        {
            _cardDeck = cardDeck;
        }


        public bool PlayGame(IList<IRule> rules)
        {
            _cardDeck.Shuffle();
            hand = new Hand(_cardDeck.DrawCards(nbrCardsInHand));

            foreach(IRule rule in rules)
            {
                if (!rule.ValidateRule(hand))
                { 
                    return false;
                }
            }
            return true;
        }

        public Hand GetHand()
        {
            return hand;
        }
    }
}
