using System;
namespace StraightFlush
{
    public class Card
    {
        public Suites Suite { get; set; }
        public int Value { get; set; }

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
