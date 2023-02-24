using CardMatchTask.Model;
using static CardMatchTask.Model.Constants;

namespace CardMatchTask.Service
{
    public class CardMatchGameFlow
    {
        private DeckOfCardsGetter deckOfCardsGetter;
        private ShuffleCards shuffleCards;
        private CardMatchGame cardMatchGame;
        public string FlowCardMatchGame(int cardPacks, MatchCondition matchCondition)
        {
            //combine no of card packs
            deckOfCardsGetter = new DeckOfCardsGetter();
            List<Card> deckOfCards = deckOfCardsGetter.GetDeckOfCards(cardPacks);
            
            //Shuffle Cards
            shuffleCards = new ShuffleCards();
            shuffleCards.Shuffle(deckOfCards);
            
            //CardMatchGame
            cardMatchGame = new CardMatchGame();
            string gameResult = cardMatchGame.MatchCardGame(deckOfCards, matchCondition);

            return gameResult;
        }
    }
}
