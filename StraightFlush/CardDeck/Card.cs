using System;
namespace StraightFlush
{
    public class Card
    {
        public Suites Suite { get; }
        public int Value { get; }

        public Card(Suites suite, int value)
        {
            Suite = suite;
            Value = value;
        }

        public enum Suites
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }

        public string NamedValue
        {
            get
            {
                string name = "";
                switch (Value)
                {
                    case (1):
                        name = "Ace";
                        break;
                    case (13):
                        name = "King";
                        break;
                    case (12):
                        name = "Queen";
                        break;
                    case (11):
                        name = "Jack";
                        break;
                    default:
                        name = Value.ToString();
                        break;
                }
                return name;
            }
        }
    }
}
