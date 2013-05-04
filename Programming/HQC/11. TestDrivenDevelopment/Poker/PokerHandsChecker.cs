using System;
using System.Collections.Generic;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            bool haveFiveCards = false;
            bool dontHaveDuplicates = true;

            if (hand.Cards.Count == 5)
            {
                haveFiveCards = true;
            }

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Face == hand.Cards[i + 1].Face &&
                    hand.Cards[i].Suit == hand.Cards[i + 1].Suit)
                {
                    dontHaveDuplicates = false;
                    break;
                }
            }

            bool isValid = haveFiveCards && dontHaveDuplicates;
            return isValid;
        }

        public bool IsStraightFlush(IHand hand)
        {
            if (IsValidHand(hand))
            {
                bool hasStraight = CheckForStraight(hand);
                bool hasFlush = CheckForFlush(hand);

                if (hasStraight && hasFlush)
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

        public bool IsFourOfAKind(IHand hand)
        {
            if (IsValidHand(hand))
            {
                return CheckForSameCardFaces(hand, 4);
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
                bool hasThreeSameCards = false;
                int requiredCards = 1;
                Card repetedCard = new Card(CardFace.Ace, CardSuit.Clubs);

                for (int i = 0; i < hand.Cards.Count; i++)
                {
                    for (int j = i + 1; j < hand.Cards.Count; j++)
                    {
                        if (hand.Cards[i].Face == hand.Cards[j].Face)
                        {
                            requiredCards++;

                            if (requiredCards == 3)
                            {
                                //Save the first repeated card in threeOfAKind
                                repetedCard = new Card((CardFace)hand.Cards[i].Face, (CardSuit)hand.Cards[i].Suit);
                                hasThreeSameCards = true;
                                break;
                            }
                        }

                        //If checked to the last card and still hand isnt valid
                        if (j == hand.Cards.Count - 1)
                        {
                            requiredCards = 1;
                        }
                    }
                }

                bool hasAnotherPair = false;
                const int twoPairsCardsRequired = 2;

                for (int i = 0; i < hand.Cards.Count; i++)
                {
                    for (int j = i + 1; j < hand.Cards.Count; j++)
                    {
                        //If find a dublicate face but its not
                        //the card which exist in the threeOfAKind
                        if (hand.Cards[i].Face == hand.Cards[j].Face &&
                            hand.Cards[i].Face != repetedCard.Face)
                        {
                            requiredCards++;

                            if (requiredCards == twoPairsCardsRequired)
                            {
                                hasAnotherPair = true;
                                break;
                            }
                        }

                        //If checked to the last card and still hand isnt valid
                        if (j == hand.Cards.Count - 1)
                        {
                            requiredCards = 1;
                        }
                    }
                }

                if (hasThreeSameCards && hasAnotherPair)
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

        public bool IsFlush(IHand hand)
        {
            if (IsValidHand(hand) && !IsFourOfAKind(hand) &&
                !IsStraightFlush(hand) && !IsFullHouse(hand))
            {
                return CheckForFlush(hand);
            }
            else
            {
                return false;
            }
            
        }

        private bool CheckForFlush(IHand hand)
        {
            int hasClubs = 0;
            int hasDiamonds = 0;
            int hasHearths = 0;
            int hasSpades = 0;

            if (IsValidHand(hand))
            {
                foreach (Card card in hand.Cards)
                {
                    switch (card.Suit)
                    {
                        case CardSuit.Clubs: hasClubs++; break;
                        case CardSuit.Diamonds: hasDiamonds++; break;
                        case CardSuit.Hearts: hasHearths++; break;
                        case CardSuit.Spades: hasSpades++; break;
                        default:
                            throw new ArgumentException("Invalid card suit!");
                    }
                }
            }

            if (hasClubs >= 4 ||
                hasDiamonds >= 4 ||
                hasHearths >= 4 ||
                hasSpades >= 4)
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
            if (IsValidHand(hand) && !IsStraightFlush(hand) && !IsFlush(hand))
            {
                return CheckForStraight(hand);
            }
            else
            {
                return false;
            }
        }

        private bool CheckForStraight(IHand hand)
        {
            int higherCardFace = int.MinValue;

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                if (higherCardFace < (int)hand.Cards[i].Face)
                {
                    higherCardFace = (int)hand.Cards[i].Face;
                }
            }

            bool hasCardTwo = CheckForSpecificCard(hand, 5);

            //If you have Ace check do you have 2.If you have then ace
            //will be used for low straight and make 5 highest card.
            if (higherCardFace == 14 && hasCardTwo)
            {
                higherCardFace = 5;
            }

            bool hasStraight = false;

            if (higherCardFace == 5)
            {
                hasStraight = CheckForLowerStraight(hand, higherCardFace);
            }
            else
            {
                hasStraight = CheckForHighStraight(hand, higherCardFace);
            }

            return hasStraight;
        }

        private bool CheckForSpecificCard(IHand hand, int card)
        {
            bool hasYourCard = false;
            int yourCard = card;

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                if (yourCard == (int)hand.Cards[i].Face)
                {
                    hasYourCard = true;
                    break;
                }
            }
            return hasYourCard;
        }

        private bool CheckForLowerStraight(IHand hand, int higherCardFace)
        {
            int requiredFourCards = 1;

            foreach (Card card in hand.Cards)
            {
                if ((int)card.Face == (int)higherCardFace - 1)
                {
                    requiredFourCards++;
                }
                else if ((int)card.Face == (int)higherCardFace - 2)
                {
                    requiredFourCards++;
                }
                else if ((int)card.Face == (int)higherCardFace - 3)
                {
                    requiredFourCards++;
                }
            }

            if (requiredFourCards == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckForHighStraight(IHand hand, int higherCardFace)
        {
            int requiredFiveCards = 1;

            foreach (Card card in hand.Cards)
            {
                if ((int)card.Face == (int)higherCardFace - 1)
                {
                    requiredFiveCards++;
                }
                else if ((int)card.Face == (int)higherCardFace - 2)
                {
                    requiredFiveCards++;
                }
                else if ((int)card.Face == (int)higherCardFace - 3)
                {
                    requiredFiveCards++;
                }
                else if ((int)card.Face == (int)higherCardFace - 4)
                {
                    requiredFiveCards++;
                }
            }

            if (requiredFiveCards == 5)
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
            if (IsValidHand(hand) && !IsFlush(hand) &&
                !IsFourOfAKind(hand) && !IsFullHouse(hand))
            {
                return CheckForSameCardFaces(hand, 3);
            }
            else
            {
                return false;
            }
        }

        private bool CheckForSameCardFaces(IHand hand, int requiredSameCardFacesForHand)
        {
            int requiredCards = 1;

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        requiredCards++;

                        if (requiredCards == requiredSameCardFacesForHand)
                        {
                            return true;
                        }
                    }

                    //If checked to the last card and still hand isnt valid
                    if (j == hand.Cards.Count - 1)
                    {
                        requiredCards = 1;
                    }
                }
            }
            return false;
        }

        public bool IsTwoPair(IHand hand)
        {
            if (IsValidHand(hand) && !IsThreeOfAKind(hand) &&
                !IsFourOfAKind(hand) && !IsFullHouse(hand))
            {
                int firstPairCardFace = int.MaxValue;
                bool checkForFirstPair = false;
                bool checkForSecondPair = false;

                for (int i = 0; i < hand.Cards.Count - 1; i++)
                {
                    for (int j = i + 1; j < hand.Cards.Count; j++)
                    {
                        if (hand.Cards[i].Face == hand.Cards[j].Face)
                        {
                            checkForFirstPair = true;
                            firstPairCardFace = (int)hand.Cards[i].Face;
                            break;
                        }
                    }
                }

                for (int i = 0; i < hand.Cards.Count- 1; i++)
                {
                    for (int j = i + 1; j < hand.Cards.Count; j++)
                    {
                        //When check for second pair make sure you dont
                        //check again for the same pair as the first
                        if (hand.Cards[i].Face == hand.Cards[j].Face &&
                            (int)hand.Cards[i].Face != firstPairCardFace)
                        {
                            checkForSecondPair = true;
                            break;
                        }
                    }
                }

                return checkForFirstPair && checkForSecondPair;
            }
            else
            {
                return false;
            }
        }

        public bool IsOnePair(IHand hand)
        {
            if (IsValidHand(hand) && !IsTwoPair(hand) && !IsThreeOfAKind(hand) &&
                !IsFourOfAKind(hand) && !IsFullHouse(hand))
            {
                return CheckForSameCardFaces(hand, 2);
            }
            else
            {
                return false;
            }
        }

        public bool IsHighCard(IHand hand)
        {
            if (IsValidHand(hand) && !IsOnePair(hand) && !IsTwoPair(hand) &&
                !IsThreeOfAKind(hand) && !IsStraight(hand) && !IsFlush(hand) &&
                !IsFourOfAKind(hand) && !IsStraightFlush(hand) && !IsFullHouse(hand))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //TODO
        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}