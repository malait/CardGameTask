using static CardMatchTask.Model.Constants;

namespace CardMatchTask.Model
{
    public class PackOfCards
    {
        public List<Card> cards { get; }
        public PackOfCards()
        {
            cards = new List<Card>();
            for (int i = 2; i <= 10; i++)
            {
                cards.Add(new NumberCard() { number = i, cardColor = CardColor.black, cardSuit = CardSuit.clubs});
                cards.Add(new NumberCard() { number = i, cardColor = CardColor.black, cardSuit = CardSuit.spades });
                cards.Add(new NumberCard() { number = i, cardColor = CardColor.red, cardSuit = CardSuit.hearts });
                cards.Add(new NumberCard() { number = i, cardColor = CardColor.red, cardSuit = CardSuit.diamonds });
            }
            char[] faces = { 'A', 'K', 'Q', 'J' };
            foreach (char ch in faces)
            {
                cards.Add(new FaceCard() { faceValue = ch, cardColor = CardColor.black, cardSuit = CardSuit.clubs });
                cards.Add(new FaceCard() { faceValue = ch, cardColor = CardColor.black, cardSuit = CardSuit.spades });
                cards.Add(new FaceCard() { faceValue = ch, cardColor = CardColor.red, cardSuit = CardSuit.hearts });
                cards.Add(new FaceCard() { faceValue = ch, cardColor = CardColor.red, cardSuit = CardSuit.diamonds });
            }
        }
    }
}
