using System;
using AMSGeekChallenge;

class Program
{
    static void Main()
    {
        Deck deck = new Deck();
        deck.Shuffle();

        Console.WriteLine("Dealing cards:");
        for (int i = 0; i < 52; i++)
        {
            Card card = deck.DealOneCard();
            Console.WriteLine(card.ToString());
        }
    }
}
