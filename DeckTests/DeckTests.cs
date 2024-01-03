
namespace DeckTests
{

    using NUnit.Framework;
    using System.Linq;


    [TestFixture]
    public class DeckTests
    {
        private Deck deck;

        [SetUp]
        public void Setup()
        {
            deck = new Deck();
        }

        [Test]
        public void Deck_InitializesWith52Cards()
        {
            int expectedCardCount = 52;
            int actualCardCount = deck.GetCardsCount(); // You need to implement GetCardsCount in Deck class

            Assert.AreEqual(expectedCardCount, actualCardCount);
        }

        [Test]
        public void Shuffle_RandomizesDeck()
        {
            var originalOrder = deck.GetCards().ToList(); // Implement GetCards to return a copy of the cards list
            deck.Shuffle();
            var shuffledOrder = deck.GetCards().ToList();

            Assert.IsFalse(originalOrder.SequenceEqual(shuffledOrder));
        }

        [Test]
        public void DealOneCard_ReturnsCard()
        {
            var card = deck.DealOneCard();
            Assert.IsNotNull(card);
            Assert.IsInstanceOf<Card>(card);
        }

        [Test]
        public void DealOneCard_RemovesCardFromDeck()
        {
            int initialCount = deck.GetCardsCount();
            deck.DealOneCard();
            int finalCount = deck.GetCardsCount();

            Assert.AreEqual(initialCount - 1, finalCount);

        }

    }
}