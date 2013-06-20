using System;
using System.Collections;
using System.Collections.Generic;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStraightFlush(IHand hand)
        {
            if (IsValidHand(hand) &&
                AreConsecutive(hand) &&
                AreTheSameSuit(hand))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (IsValidHand(hand))
            {
                return HaveCardsWithSameFaceWithExactCount(hand, 4, 1);
            }
            else
            {
                return false;
            }
        }

        public bool IsFullHouse(IHand hand)
        {
            if (IsValidHand(hand))
            {
                return HaveCardsWithSameFaceWithExactCount(hand, 3, 1) && HaveCardsWithSameFaceWithExactCount(hand, 2, 1);
            }
            else
            {
                return false;
            }

        }

        public bool IsFlush(IHand hand)
        {
            if (IsValidHand(hand) &&
                AreTheSameSuit(hand) &&
                !AreConsecutive(hand))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStraight(IHand hand)
        {
            if (IsValidHand(hand) &&
               AreConsecutive(hand) &&
               !AreTheSameSuit(hand))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            if (IsValidHand(hand))
            {
                return HaveCardsWithSameFaceWithExactCount(hand, 3, 1) && !HaveCardsWithSameFaceWithExactCount(hand, 2, 1);
            }
            else
            {
                return false;
            }
        }

        public bool IsTwoPair(IHand hand)
        {
            if (IsValidHand(hand))
            {
                return HaveCardsWithSameFaceWithExactCount(hand, 2, 2);
            }
            else
            {
                return false;
            }
        }

        public bool IsOnePair(IHand hand)
        {
            if (IsValidHand(hand))
            {
                return HaveCardsWithSameFaceWithExactCount(hand, 2, 1) &&
                      !HaveCardsWithSameFaceWithExactCount(hand, 3, 1);
            }
            else
            {
                return false;
            }
        }

        public bool IsHighCard(IHand hand)
        {
            if (IsValidHand(hand))
            {
                if (AreTheSameSuit(hand) ||
                    AreConsecutive(hand) ||
                    HaveCardsWithSameFace(hand))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }

        private bool AreTheSameSuit(IHand hand)
        {
            for (int card = 1; card < hand.Cards.Count; card++)
            {
                if (hand.Cards[card].Suit != hand.Cards[card - 1].Suit)
                {
                    return false;
                }
            }
            return true;
        }

        private bool AreConsecutive(IHand hand)
        {
            if (hand is Hand)
            {
                (hand as Hand).Sort();
                int cardsLength = hand.Cards.Count;

                // In case of the cards are A 2 3 4 5 which are consequtive sequance, but the algorithm won't work.
                // So if the Hand looks like this: ( Two. .... X. Ace. where X is different to Ace) after the sort 
                // we return the same value of this method when it is called with the subsequance without the last (Ace)
                if (hand.Cards[cardsLength - 1].Face == CardFace.Ace &&
                    hand.Cards[cardsLength - 2].Face != CardFace.Ace &&
                    hand.Cards[0].Face == CardFace.Two)
                {
                    IList<ICard> subCards = (hand.Cards as List<ICard>).GetRange(0, cardsLength - 1);
                    IHand subHand = new Hand(subCards);
                    return AreConsecutive(subHand);
                }
                else
                {
                    for (int card = 1; card < cardsLength; card++)
                    {
                        if ((int)hand.Cards[card].Face - 1 != (int)hand.Cards[card - 1].Face)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            else
            {
                // TODO: Implement the method if the hand is not Hand!
                throw new NotImplementedException("AreConsecutive() is not implemented if the hand argument isn't Hand!");
            }
        }

        private bool HaveCardsWithSameFace(IHand hand)
        {
            for (int card = 1; card < hand.Cards.Count; card++)
            {
                if (hand.Cards[card].Face == hand.Cards[card - 1].Face)
                {
                    return true;
                }
            }

            return false;
        }

        private bool HaveCardsWithSameFaceWithExactCount(IHand hand, int countOfCardsWithSameFace, int countSeen)
        {
            int cardFacesCount = 13;
            int[] cardFaces = new int[cardFacesCount];
            for (int card = 0; card < hand.Cards.Count; card++)
            {
                cardFaces[(int)hand.Cards[card].Face - 2]++;
            }

            int seen = 0;

            for (int cardFace = 0; cardFace < cardFacesCount; cardFace++)
            {
                if (cardFaces[cardFace] == countOfCardsWithSameFace)
                {
                    seen++;
                }
            }

            if (seen == countSeen)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
