using CardMatchTask.Model;

namespace CardMatchTask.Service
{
    public class ShuffleCards
    {
        public void Shuffle(List<Card> cards)
        {
            Random rand = new Random();
            var shuffled = cards.OrderBy(_ => rand.Next()).ToList();
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int k = rand.Next(i + 1);
                Card tempCard = cards[k];
                cards[k] = cards[i];
                cards[i] = tempCard;
            }
        }
    }
}
