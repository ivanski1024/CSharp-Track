using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace TestPoker
{
    [TestClass]
    public class PokerHandsCheckerTest
    {
        [TestMethod]
        public void IsValidTest1()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            IHand hand = HandGenerator1();
            if (!checker.IsValidHand(hand))
            {
                throw new TestNotPassedException();
            }
        }

        [TestMethod]
        public void IsValidTest2()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            IHand hand = HandGenerator2();
            if (checker.IsValidHand(hand))
            {
                throw new TestNotPassedException();
            }
        }


        private Hand HandGenerator1()
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


        private Hand HandGenerator2()
        {
            IList<ICard> handList = new List<ICard>();
            handList.Add(new Card(CardFace.Ten, CardSuit.Spades));
            handList.Add(new Card(CardFace.Jack, CardSuit.Spades));
            handList.Add(new Card(CardFace.Queen, CardSuit.Spades));
            handList.Add(new Card(CardFace.King, CardSuit.Spades));
            Hand hand = new Hand(handList);
            return hand;
        }
    }
}
