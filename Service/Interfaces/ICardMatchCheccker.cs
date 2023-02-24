using CardMatchTask.Model;

namespace CardMatchTask.Service.Interfaces
{
    public interface ICardMatchCheccker
    {
        bool CheckCardMatch(Card previousCard, Card currentCard);
    }
}
