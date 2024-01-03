
namespace AMSGeekChallenge
{
    using System;
    using System.Collections.Generic;

    public enum Suit
    {
        Hearts, Diamonds, Clubs, Spades
    }

    public enum Rank
    {
        Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }

    public class Card
    {
        public Suit Suit { get; private set; }
        public Rank Rank { get; private set; }

        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

    public class Deck
    {
        private List<Card> cards;
        private Random random;

        public Deck()
        {
            random = new Random();
            cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        public void Shuffle()
        {
            for (int n = cards.Count - 1; n > 0; --n)
            {
                int k = random.Next(n + 1);
                Card temp = cards[n];
                cards[n] = cards[k];
                cards[k] = temp;
            }
        }

        public Card DealOneCard()
        {
            if (cards.Count == 0)
            {
                throw new Exception("No cards to deal");
                
            }

            Card cardToDeal = cards[0];
            cards.RemoveAt(0);
            return cardToDeal;
        }

        public int GetCardsCount()
        {
            return cards.Count;
        }
        public List<Card> GetCards()
        {
            return new List<Card>(cards);
        }
       
    }

}

