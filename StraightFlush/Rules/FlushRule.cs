using System;
using System.Linq;

namespace StraightFlush
{
    public class FlushRule : IRule
    {
        public bool ValidateRule(Hand hand)
        {
            return hand.CardsInHand.GroupBy(c => c.Suite).Count(group => group.Count() >= hand.CardsInHand.Count) == 1;
        }
    }
}
