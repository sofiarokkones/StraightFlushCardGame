using System;
namespace StraightFlush
{
    public class Card
    {
        public enum Suites
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }

        public Suites Suite { get; set; }
        public int Value { get; set; }
    }
}
