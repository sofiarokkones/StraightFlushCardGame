using System.Linq;

namespace StraightFlush
{
    public class StraightRule : IRule
    {
        public bool ValidateRule(Hand hand)
        {
            var sortedHand = hand.CardsInHand.OrderBy(x => x.Value);
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
}
