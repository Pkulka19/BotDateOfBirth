using BotDateofBirth.Core.Enums;

namespace BotDateofBirth.Core
{
    public static class EnumExtention
    {
        public static string ToPolishString(this DayOfTheWeek dayOfTheWeek)
        {
            switch (dayOfTheWeek)
            {
                case DayOfTheWeek.Monday:
                    {
                        return "Poniedziałek";
                    }
                    break;
                case DayOfTheWeek.Tuesday:
                    {
                        return "Wtorek";
                    }
                    break;
                case DayOfTheWeek.Wednesday:
                    {
                        return "Środa";     
                    }
                    break;
                case DayOfTheWeek.Thursday:
                    {
                        return "Czwartek";
                    }
                    break;
                case DayOfTheWeek.Friday:
                    {
                        return "Piątek";
                    }
                    break;
                case DayOfTheWeek.Saturday:
                    {
                        return "Sobota";
                    }
                    break;
                case DayOfTheWeek.Sunday:
                    {
                        return "Niedziela";
                    }
                    break;

                default:
                    return "Poniedziałęk";
            }

        }  
    }
}
