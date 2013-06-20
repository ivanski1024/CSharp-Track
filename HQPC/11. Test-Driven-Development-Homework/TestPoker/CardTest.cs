namespace TestPoker
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void CardConstructorTest()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Spades);
            if (card.Face != CardFace.Ace || card.Suit != CardSuit.Spades)
            {
                throw new TestNotPassedException();
            }
        }

        [TestMethod]
        public void CardToStringTest1()
        {
            Card sevenOfClubs = new Card(CardFace.Seven, CardSuit.Clubs);
            if (sevenOfClubs.ToString() != "7♣")
            {
                throw new TestNotPassedException();
            }
        }

        [TestMethod]
        public void CardToStringTest2()
        {
            Card jackOfDiamonds = new Card(CardFace.Jack, CardSuit.Diamonds);
            if (jackOfDiamonds.ToString() != "J♦")
            {
                throw new TestNotPassedException();
            }
        }

        [TestMethod]
        public void CardToStringTest3()
        {
            Card queenOfSpades = new Card(CardFace.Queen, CardSuit.Spades);
            if (queenOfSpades.ToString() != "Q♠")
            {
                throw new TestNotPassedException();
            }
        }

        [TestMethod]
        public void CardToStringTest4()
        {
            Card kingOfHearts = new Card(CardFace.King, CardSuit.Hearts);
            if (kingOfHearts.ToString() != "K♥")
            {
                throw new TestNotPassedException();
            }
        }

        [TestMethod]
        public void CardToStringTest5()
        {
            Card aceOfSpades = new Card(CardFace.Ace, CardSuit.Spades);
            if (aceOfSpades.ToString() != "A♠")
            {
                throw new TestNotPassedException();
            }
        }

        [TestMethod]
        public void CardEqualsTest1()
        {
            if(! new Card(CardFace.Ace, CardSuit.Spades).Equals(new Card(CardFace.Ace, CardSuit.Spades)))
            {
                throw new TestNotPassedException("Card.Equals() test with same elements doesn't work correctly!");
            }
        }

        [TestMethod]
        public void CardEqualsTest2()
        {
            if (new Card(CardFace.Ace, CardSuit.Spades).Equals(new Card(CardFace.Queen, CardSuit.Hearts)))
            {
                throw new TestNotPassedException("Card.Equals() test with different elements of the same type doesn't work correctly!");
            }
        }

        [TestMethod]
        public void CardEqualsTest3()
        {
            if (new Card(CardFace.Ace, CardSuit.Spades).Equals(new Object()))
            {
                throw new TestNotPassedException("Card.Equals() test with objects of different types doesn't work correctly!");
            }
        }
    }
}
