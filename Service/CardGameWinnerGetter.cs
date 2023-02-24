namespace CardMatchTask.Service
{
    public class CardGameWinnerGetter
    {
        public string GetCardGameWinner(int player1Pile,int player2Pile)
        {
            string winner = string.Empty;
            if (player1Pile == player2Pile)
                winner = "draw";
            else if (player1Pile > player2Pile)
                winner = "Player1";
            else if (player2Pile > player1Pile)
                winner = "Player2";
            return winner;
        }
    }
}
