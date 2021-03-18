﻿using System;
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

            rules.Add(new StraightRule());
            rules.Add(new FlushRule());
            //rules.Add(new RoyalStraightRule());

            var tries = 0;
            var sw = Stopwatch.StartNew();

            while (!game.PlayGame(rules))
            {
                tries++;
            }

            sw.Stop();
            var hand = game.GetHand();
            var sortedHand = hand.cardsInHand.OrderBy(x => x.Value);


            foreach (Card card in sortedHand)
            {
                Console.WriteLine($"{card.Suite} - {card.Value}");
            }

            var ts = sw.Elapsed.TotalSeconds;

            Console.WriteLine($"Time {ts: N3} s");
            Console.WriteLine($"{tries} tries was executed to reach a Straight Flush! ");
        }
    }
}
