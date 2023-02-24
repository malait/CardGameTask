using CardMatchTask.Model;
using CardMatchTask.Service.Interfaces;

namespace CardMatchTask.Service
{
    public class ValueMatchChecker : ICardMatchCheccker
    {
        public bool CheckCardMatch(Card previousCard, Card currentCard)
        {
            bool isValueMatch = false;
            if (previousCard is NumberCard && currentCard is NumberCard)
            {
                isValueMatch = ((NumberCard)previousCard).number == ((NumberCard)currentCard).number;
            }
            if (previousCard is FaceCard && currentCard is FaceCard)
            {
                isValueMatch = ((FaceCard)previousCard).faceValue == ((FaceCard)currentCard).faceValue;
            }
            return isValueMatch;
        }
    }
}
