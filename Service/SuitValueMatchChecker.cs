using CardMatchTask.Model;
using CardMatchTask.Service.Interfaces;

namespace CardMatchTask.Service
{
    public class SuitValueMatchChecker : ICardMatchCheccker
    {
        private SuitMatchChecker suitMatchChecker;
        private ValueMatchChecker valueMatchChecker;

        public bool CheckCardMatch(Card previousCard, Card currentCard)
        {
            suitMatchChecker = new SuitMatchChecker();
            valueMatchChecker = new ValueMatchChecker();

            return suitMatchChecker.CheckCardMatch(previousCard, currentCard) &&
                    valueMatchChecker.CheckCardMatch(previousCard, currentCard);
        }
    }
}
