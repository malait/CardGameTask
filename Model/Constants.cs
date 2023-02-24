namespace CardMatchTask.Model
{
    public class Constants
    {
        public enum CardColor
        {
            black,
            red
        }
        public enum CardSuit
        {
            clubs,
            diamonds,
            hearts,
            spades
        }

        public enum MatchCondition
        {
            suits,
            values,
            suitAndValues
        }
    }
}
