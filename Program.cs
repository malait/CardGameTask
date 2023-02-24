// See https://aka.ms/new-console-template for more information
using CardMatchTask.Service;
using static CardMatchTask.Model.Constants;

Console.WriteLine("Hello, World!");
Console.Write("Enter the Pack of Cards : ");
int packOfCards = Convert.ToInt32(Console.ReadLine());
if(packOfCards >= 1)
{
    Console.Write("Match Conditions : \n\t 1.Suit\n\t 2.Value \n");
    if (packOfCards >= 2)
        Console.Write("\t 3.Suit and Value\n");
    Console.Write("Enter your option :");
    int matchCondition = Convert.ToInt32(Console.ReadLine());
    if(matchCondition ==1 || matchCondition ==2 || (packOfCards>=2 && matchCondition==3))
    {
        MatchCondition condition = (MatchCondition)matchCondition - 1;
        CardMatchGameFlow cardMatchGameFlow = new CardMatchGameFlow();
        
        Console.WriteLine("**********************************************************");
        Console.WriteLine("\t\t\t" + cardMatchGameFlow.FlowCardMatchGame(packOfCards, condition));
        Console.WriteLine("**********************************************************");
    }
    else
    {
        Console.WriteLine("Invalid Match Condition");
    }
}
else
{
    Console.WriteLine("Invalid Pack of Cards");
}