using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StraightFlush;
using static StraightFlush.Card;

namespace CardGameTest
{
    [TestClass]
    public class CardGameTester
    {
        private IRule rule;

        [TestMethod]
        public void Test_correct_flush_rule()
        {
            var hand = new Hand(new List<Card> {
                new Card(Suites.Clubs, 1),
                new Card(Suites.Clubs, 7),
                new Card(Suites.Clubs, 3),
                new Card(Suites.Clubs, 2),
                new Card(Suites.Clubs, 11)
            });

            rule = new FlushRule();
            Assert.IsTrue(rule.ValidateRule(hand));
        }

        [TestMethod]
        public void Test_correct_straight_rule()
        {
            var hand = new Hand(new List<Card> {
                new Card(Suites.Clubs, 5),
                new Card(Suites.Hearts, 6),
                new Card(Suites.Diamonds, 3),
                new Card(Suites.Spades, 2),
                new Card(Suites.Clubs, 4)
            });

            rule = new StraightRule();
            Assert.IsTrue(rule.ValidateRule(hand));
        }

        [TestMethod]
        public void Test_correct_royalstraight_rule()
        {
            var hand = new Hand(new List<Card> {
                new Card(Suites.Clubs, 11),
                new Card(Suites.Clubs, 12),
                new Card(Suites.Clubs, 1),
                new Card(Suites.Clubs, 10),
                new Card(Suites.Clubs, 13)
            });
            rule = new RoyalStraightRule();
            Assert.IsTrue(rule.ValidateRule(hand));
        }

        [TestMethod]
        public void Test_incorrect_flush_rule()
        {
            var hand = new Hand(new List<Card> {
                new Card(Suites.Clubs, 11),
                new Card(Suites.Hearts, 12),
                new Card(Suites.Spades, 1),
                new Card(Suites.Spades, 7),
                new Card(Suites.Clubs, 13)
            });

            rule = new FlushRule();
            Assert.IsFalse(rule.ValidateRule(hand));
        }

        [TestMethod]
        public void Test_incorrect_straight_rule()
        {
            var hand = new Hand(new List<Card> {
                new Card(Suites.Clubs, 11),
                new Card(Suites.Clubs, 8),
                new Card(Suites.Clubs, 1),
                new Card(Suites.Clubs, 10),
                new Card(Suites.Clubs, 13)
            });

            rule = new StraightRule();
            Assert.IsFalse(rule.ValidateRule(hand));
        }

        [TestMethod]
        public void Test_incorrect_royalstraight_rule()
        {
            var hand = new Hand(new List<Card> {
                new Card(Suites.Clubs, 8),
                new Card(Suites.Clubs, 12),
                new Card(Suites.Clubs, 1),
                new Card(Suites.Clubs, 10),
                new Card(Suites.Clubs, 13)
            });

            rule = new RoyalStraightRule();
            Assert.IsFalse(rule.ValidateRule(hand));
        }
    }
}
