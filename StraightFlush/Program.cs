using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace StraightFlush
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CardDeck deck = new CardDeck();
            CardGame game = new CardGame(deck);

            List<IRule> rules = new List<IRule>();

            rules.Add(new FlushRule());
            rules.Add(new StraightRule());
            //rules.Add(new RoyalStraightRule());

            var tries = 0;
            var sw = Stopwatch.StartNew();

            while (!game.PlayGame(rules))
            {
                tries++;
            }
            sw.Stop();
            var ts = sw.Elapsed.TotalSeconds;

            // Present the result
            var hand = game.GetHand();
            var sortedHand = hand.cardsInHand.OrderBy(x => x.Value).ToList();

            // Reorder if royal straight
            if(sortedHand.LastOrDefault().Value == 13 && sortedHand.FirstOrDefault().Value == 1)
            {
                var last = sortedHand.FirstOrDefault();
                sortedHand.RemoveAt(0);
                sortedHand.Add(last);
            }

            Console.WriteLine($"The final hand:");
            hand.PrintHand(sortedHand);

            Console.WriteLine($"Time: {ts:N} seconds ");
            Console.WriteLine($"Tries: {tries} attempts ");
            Console.WriteLine($"There were {tries/ts:N} tries per second executed.");
        }
    }
}
