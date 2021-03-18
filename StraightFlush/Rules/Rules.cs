using System;
using System.Linq;

namespace StraightFlush
{
    public class FlushRule : IRule
    {
        public bool ValidateRule(Hand hand)
        {
            var firstSuite = hand.cardsInHand.First().Suite;
            foreach (Card card in hand.cardsInHand)
            {
                if (firstSuite != card.Suite)
                    return false;
            }
            return true;
        }
    }


    public class StraightRule : IRule
    {
        public bool ValidateRule(Hand hand)
        {
            var sortedHand = hand.cardsInHand.OrderBy(x => x.Value);
            var prevCardVal = sortedHand.First().Value;
            var first = true;

            foreach (Card card in sortedHand)
            {
                if (!first)
                {
                    if (!(prevCardVal == 1 && card.Value == 10))
                    {
                        if (!(prevCardVal == card.Value - 1))
                            return false;
                    }
                }
                first = false;
                prevCardVal = card.Value;
            }
            return true;
        }
    }


    public class RoyalStraightRule : IRule
    {
        public bool ValidateRule(Hand hand)
        {
            var sortedHand = hand.cardsInHand.OrderBy(x => x.Value);
            var prevCardVal = sortedHand.First().Value;
            var first = true;

            foreach (Card card in sortedHand)
            {
                if (first && prevCardVal != 1)
                {
                    return false;
                }
                else if (!(prevCardVal == 1 && card.Value == 10))
                {
                    if (!first && !(prevCardVal == card.Value - 1))
                        return false;
                }
                first = false;
                prevCardVal = card.Value;
            }
            if (prevCardVal != 13)
            {
                return false;
            }
            return true;
        }
    }
}
