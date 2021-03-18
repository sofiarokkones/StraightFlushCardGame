using System;
namespace StraightFlush
{
    public interface IRule
    {
        public bool ValidateRule(Hand hand);
    }
}
