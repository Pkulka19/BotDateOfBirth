using System;
using BotDateofBirth.Core;
using BotDateofBirth.Core.Enums;

namespace BotDateOfBirth
{
    public class DayGuesser
    {
        public DayCalculator Calculator { get; set; }

        public DateTimeOffset UserDateOfBirth { get; set; }
        public DayOfTheWeek UserDayOfTheWeek { get; set; }
        public void IntroduceTheApplication()
        {
            Console.WriteLine("Cześć jestem botem który potrafi obliczyć dzień tygodnia do daty urodzenia którą podasz");

            Calculator = new DayCalculator();
        }
        public void AskUserForDateOfBirth()
        {
            Console.WriteLine("Podaj prosze wybraną przez siebie datę urodzenia");

            var userDate = Console.ReadLine();
            
            var sucessed = DateTimeOffset.TryParse(userDate, out var date );

            if (sucessed)
            {
                UserDateOfBirth = date;
                return;
            }
            Console.WriteLine("Podano błędny format daty, podaj ją jako mm/dd/yyyy");
            AskUserForDateOfBirth();
            
        }

        public void CalculateDayOfTheWeek()
        {
            if(UserDateOfBirth == null)
            {
                Console.WriteLine("Próbowano obliczyć dzień tygodnia bez podania daty urodzenia");
                return;
            }

            UserDayOfTheWeek = Calculator.CalculateDayOfTheWeek(UserDateOfBirth);
        }
        public void PrintDayOfTheWeek()
        {
            Console.WriteLine("Obliczony dzień tygodnia to: " + UserDayOfTheWeek.ToPolishString());
        }
    }
}
