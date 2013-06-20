using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards
        {
            get;
            private set;
        }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            for (int card = 0; card < this.Cards.Count; card++)
            {
                if (card != 0)
                {
                    output.Append(" ");
                }
                output.Append(Cards[card].ToString());
            }
            return output.ToString();
        }

        public void Sort()
        {
            if (this.Cards is List<ICard>)
            {
                (this.Cards as List<ICard>).Sort();
            }
            else
            {
                // TODO: Implement Sort() if this.Cards is not List!
                throw new NotImplementedException("The Hand.Sort() method is not implemented if this.Cards is not List!");
            }
        }
    }
}
