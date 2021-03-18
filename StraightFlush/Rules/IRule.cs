using System;
namespace StraightFlush
{
    public interface IRule
    {
        bool ValidateRule(Hand hand);
    }
}
