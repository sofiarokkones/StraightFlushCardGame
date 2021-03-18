using System.Linq;

namespace StraightFlush
{
    public class RoyalStraightRule : IRule
    {
        public bool ValidateRule(Hand hand)
        {
            var straightRule = new StraightRule();
            var sortedHand = hand.CardsInHand.OrderBy(x => x.Value);
            if (straightRule.ValidateRule(hand) && sortedHand.First().Value == 1 && sortedHand.Last().Value == 13)
            {
                return true;
            }
            return false;
        }
    }
}
