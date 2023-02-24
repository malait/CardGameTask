using CardMatchTask.Model;
using CardMatchTask.Service.Interfaces;

namespace CardMatchTask.Service
{
    public class SuitMatchChecker : ICardMatchCheccker
    {
        public bool CheckCardMatch(Card previousCard, Card currentCard)
        {
            return previousCard.cardSuit == currentCard.cardSuit;
        }
    }
}
