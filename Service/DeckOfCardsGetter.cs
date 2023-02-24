using CardMatchTask.Model;

namespace CardMatchTask.Service
{
    public class DeckOfCardsGetter
    {
        private PackOfCards deckOfCards;
        public List<Card> GetDeckOfCards(int noOfPacks)
        {
            deckOfCards = new PackOfCards();
            List<Card> playingCards = new List<Card>();
            for (int i =0; i<noOfPacks; i++)
            {
                playingCards.AddRange(deckOfCards.cards);
            }

            return playingCards;
        }
    }
}
