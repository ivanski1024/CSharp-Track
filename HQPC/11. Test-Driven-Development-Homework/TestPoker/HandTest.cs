using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace TestPoker
{
    [TestClass]
    public class HandTest
    {
        private Hand GenerateHand()
        {
            IList<ICard> handList = new List<ICard>();
            handList.Add(new Card(CardFace.Ten, CardSuit.Spades));
            handList.Add(new Card(CardFace.Jack, CardSuit.Spades));
            handList.Add(new Card(CardFace.Queen, CardSuit.Spades));
            handList.Add(new Card(CardFace.King, CardSuit.Spades));
            handList.Add(new Card(CardFace.Ace, CardSuit.Spades));
            Hand hand = new Hand(handList);
            return hand;
        }

        [TestMethod]
        public void HandConstructorTest()
        {
            Hand hand = GenerateHand();

            if (hand.Cards.Count != 5)
            {
                throw new TestNotPassedException("Count problem!");
            }
        }

        [TestMethod]
        public void HandConstructorTest2()
        {
            Hand hand = GenerateHand();

            if (!hand.Cards[3].Equals(new Card(CardFace.King, CardSuit.Spades)))
            {
                throw new TestNotPassedException(string.Format("{0}", hand.Cards[3]));
            }
        }

        [TestMethod]
        public void HandToStringTest()
        {
            Hand hand = GenerateHand();

            if (hand.ToString() != "10♠ J♠ Q♠ K♠ A♠")
            {
                throw new TestNotPassedException("Hand.ToString() Test failed!");
            }
        }

    }
}
