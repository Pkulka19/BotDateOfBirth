using System;

namespace BotDateOfBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            var guesser = new DayGuesser();
            guesser.IntroduceTheApplication();
            guesser.AskUserForDateOfBirth();
            guesser.CalculateDayOfTheWeek();
            guesser.PrintDayOfTheWeek();

        }
    }
}
