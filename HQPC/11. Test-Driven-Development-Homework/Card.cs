using System;
using System.Text;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            switch (this.Face)
            {
                case CardFace.Jack:
                    output.Append("J");
                    break;
                case CardFace.Queen:
                    output.Append("Q");
                    break;
                case CardFace.King:
                    output.Append("K");
                    break;
                case CardFace.Ace:
                    output.Append("A");
                    break;
                default:
                    output.Append((int)this.Face);
                    break;
            }

            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    output.Append("♣");
                    break;
                case CardSuit.Diamonds:
                    output.Append("♦");
                    break;
                case CardSuit.Hearts:
                    output.Append("♥");
                    break;
                case CardSuit.Spades:
                    output.Append("♠");
                    break;
            }

            return output.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Card)
            {
                Card card = (obj as Card);
                if (card.Face == this.Face && card.Suit == this.Suit)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
