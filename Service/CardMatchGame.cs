using CardMatchTask.Model;
using CardMatchTask.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CardMatchTask.Model.Constants;

namespace CardMatchTask.Service
{
    public class CardMatchGame
    {
        private ICardMatchCheccker cardMatchCondition;
        private CardGameWinnerGetter cardGameWinnerGetter;
        public string MatchCardGame(List<Card> deckOfCards, MatchCondition matchCondition)
        {
            switch((int)matchCondition)
            {
                case 0: cardMatchCondition = new SuitMatchChecker(); break; 
                case 1: cardMatchCondition = new ValueMatchChecker(); break; 
                case 2: cardMatchCondition = new SuitValueMatchChecker(); break; 
                default: cardMatchCondition = null; break;
            }
            int firstPlayerScore = 0, secondPlayerScore = 0;
            Card previousCard = deckOfCards[0];
            bool isPlayer1 = true; int pile = 1;
            for(int i= 1; i<deckOfCards.Count;i++)
            {
                pile++;
                bool isCardMatch = cardMatchCondition.CheckCardMatch(previousCard, deckOfCards[i]);
                if(isCardMatch)
                {
                    if (isPlayer1)
                        firstPlayerScore = firstPlayerScore + pile;
                    else
                        secondPlayerScore = secondPlayerScore + pile;
                    i++;
                }
                pile++;
                previousCard = deckOfCards[i];
                isPlayer1 = !isPlayer1;
            }

            cardGameWinnerGetter = new CardGameWinnerGetter();
            string gameResult = cardGameWinnerGetter.GetCardGameWinner(firstPlayerScore, secondPlayerScore);
            
            return gameResult;
        }
    }
}
