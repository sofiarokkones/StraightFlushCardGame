using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StraightFlush;

namespace CardGameTest
{
    [TestClass]
    public class CardGameTester
    {
        private Hand handStraightFlush;
        private Hand handRandom;
        private Hand handRoyal;
        private readonly List<Card> cardsStrightFlush = new List<Card>();
        private readonly List<Card> cardsRandom = new List<Card>();
        private readonly List<Card> cardsRoyal = new List<Card>();
        private IRule rule;

        [TestInitialize]
        public void InitializeCardDeck()
        {
            // STRIAGHT FLUSH HAND
            for (int i = 1; i < 6; i++)
            {
                cardsStrightFlush.Add(new Card()
                {
                    Suite = Card.Suites.Clubs,
                    Value = i
                });
            }
            handStraightFlush = new Hand(cardsStrightFlush);

            // RANDOM HAND
            cardsRandom.Add(new Card()
            {
                Suite = Card.Suites.Clubs,
                Value = 1
            });
            cardsRandom.Add(new Card()
            {
                Suite = Card.Suites.Hearts,
                Value = 10
            });
            cardsRandom.Add(new Card()
            {
                Suite = Card.Suites.Spades,
                Value = 11
            });
            cardsRandom.Add(new Card()
            {
                Suite = Card.Suites.Clubs,
                Value = 3
            });
            cardsRandom.Add(new Card()
            {
                Suite = Card.Suites.Clubs,
                Value = 8
            });
            handRandom = new Hand(cardsRandom);

            // ROYAL HAND
            cardsRoyal.Add(new Card()
            {
                Suite = Card.Suites.Clubs,
                Value = 1
            });
            for (int i = 10; i < 14; i++)
            {
                cardsRoyal.Add(new Card()
                {
                    Suite = Card.Suites.Clubs,
                    Value = i
                });
            }
            handRoyal = new Hand(cardsRoyal);
        }

        [TestMethod]
        public void Test_correct_flush_rule()
        {
            rule = new FlushRule();
            Assert.IsTrue(rule.ValidateRule(handStraightFlush));
        }

        [TestMethod]
        public void Test_correct_straight_rule()
        {
            rule = new StraightRule();
            Assert.IsTrue(rule.ValidateRule(handStraightFlush));
        }

        [TestMethod]
        public void Test_correct_royalstraight_rule()
        {
            rule = new RoyalStraightRule();
            Assert.IsTrue(rule.ValidateRule(handRoyal));
        }

        [TestMethod]
        public void Test_incorrect_flush_rule()
        {
            rule = new FlushRule();
            Assert.IsFalse(rule.ValidateRule(handRandom));
        }

        [TestMethod]
        public void Test_incorrect_straight_rule()
        {
            rule = new StraightRule();
            Assert.IsFalse(rule.ValidateRule(handRandom));
        }

        [TestMethod]
        public void Test_incorrect_royalstraight_rule()
        {
            rule = new RoyalStraightRule();
            Assert.IsFalse(rule.ValidateRule(handRandom));
        }
    }
}
