using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StraightFlush;

namespace CardGameTest
{
    [TestClass]
    public class CardGameTester
    {
        private Hand handStrightFlush;
        private Hand handRandom;
        private Hand handRoyal;
        private readonly List<Card> cardsStrightFlush = new List<Card>();
        private readonly List<Card> cardsRandom = new List<Card>();
        private readonly List<Card> cardsRoyal = new List<Card>();
        private IRule rule;

        [TestInitialize]
        public void InitializeCardDeck()
        {
            for (int i = 1; i < 6; i++)
            {
                cardsStrightFlush.Add(new Card()
                {
                    Suite = Card.Suites.Clubs,
                    Value = i
                });
            }
            handStrightFlush = new Hand(cardsStrightFlush);

            cardsRandom.Add(new Card()
            {
                Suite = Card.Suites.Clubs,
                Value = 2
            });
            cardsRandom.Add(new Card()
            {
                Suite = Card.Suites.Hearts,
                Value = 6
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

            cardsRoyal.Add(new Card()
            {
                Suite = Card.Suites.Clubs,
                Value = 1
            });
            cardsRoyal.Add(new Card()
            {
                Suite = Card.Suites.Clubs,
                Value = 12
            });
            cardsRoyal.Add(new Card()
            {
                Suite = Card.Suites.Clubs,
                Value = 11
            });
            cardsRoyal.Add(new Card()
            {
                Suite = Card.Suites.Clubs,
                Value = 13
            });
            cardsRoyal.Add(new Card()
            {
                Suite = Card.Suites.Clubs,
                Value = 10
            });
            handRoyal = new Hand(cardsRoyal);
        }

        [TestMethod]
        public void Test_correct_flush_rule()
        {
            rule = new FlushRule();
            Assert.IsTrue(rule.ValidateRule(handStrightFlush));
        }

        [TestMethod]
        public void Test_correct_straight_rule()
        {
            rule = new StraightRule();
            Assert.IsTrue(rule.ValidateRule(handStrightFlush));
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
