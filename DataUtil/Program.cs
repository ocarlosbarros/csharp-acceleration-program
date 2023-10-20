namespace DataUtil
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var date = new DateTime(2022, 10, 2, 8, 35, 0);
            Console.WriteLine(date.ToString());//02/10/2022 08:35:00

            var now = DateTime.Now;
            Console.WriteLine(now.GetType());//System.DateTime

            Console.WriteLine(GetTimeNow());
            Console.WriteLine(DateTime.Today);//returns only Date with time 00:00:00
            Console.WriteLine(date.Date);//returns date with time defined midnight
            Console.WriteLine(date.Day);//returns day from DateTime instance
            Console.WriteLine(date.Month);//returns month from DateTime instance
            Console.WriteLine(date.Year);//returns year from DateTime instance
            Console.WriteLine(date.Hour);//returns hour from DateTime instance
            Console.WriteLine(date.Minute);//returns minute from DateTime instance
            Console.WriteLine(date.Second);//returns second from DateTime instance
            Console.WriteLine(date.Millisecond);//returns millisecond from DateTime instance
            Console.WriteLine(date.DayOfWeek);//returns day of week from DateTime instance


            //DateTime functions

            /* 
                Add(TimeSpan value)
                Sum a TimeSpan positive or negative the Date
                TimeSpan: time interval
                */
            var currentDay = DateTime.Now;
            var duration = new TimeSpan(36,0,0,0);//36 days
            var durationNegative = new TimeSpan(-7,0,0,0);//36 days

            var answer = currentDay.Add(duration); //Add 36 day 
            var leastAWeek = currentDay.Add(durationNegative);//-7
            
            Console.WriteLine("Hoje é " +currentDay.Day +"/" +currentDay.Month +" - " +currentDay.DayOfWeek);
            Console.WriteLine("Daqui a 36 dias será "+answer.Day +"/" +answer.Month +" - " +answer.DayOfWeek);
            Console.WriteLine("A uma semana atrás era "+leastAWeek.Day +"/" +leastAWeek.Month +" - " +leastAWeek.DayOfWeek);

            /*
                Others Add methods
                .AddYears(int value)
                .AddMonths(int value)
                .AddDays(double value)
                .AddHours(double value)
                .AddMinutes(double value)
                .AddSeconds(double value)
                .AddMilliseconds(double value)
            */

            /* Compare()
                return -1 0 and 1
            */
            DateTime firstDate = new DateTime(2010, 9, 1, 5, 0, 0);
            DateTime secondDate = new DateTime(2022, 8, 10, 12, 0, 0);

            int result = DateTime.Compare(firstDate, secondDate);
            string relationship;

            if (result < 0) relationship = "é anterior à";
            else if (result == 0) relationship = "è o mesmo que";
            else relationship = "è posterior à";

            Console.WriteLine("{0} {1} {2}", firstDate, relationship, secondDate);

            //ToString()
            DateTime newDate = new DateTime(2010, 9, 1, 5, 0, 0);

            Console.WriteLine($"A data é {newDate.ToString()}");

            /*
                Default patterns ToString to Date

            */
            var dateWithToString = new DateTime(2008, 6, 15, 21, 15, 07);
            Console.WriteLine("=======================================");
            Console.WriteLine(dateWithToString.ToString("d"));//15/06/2008
            Console.WriteLine(dateWithToString.ToString("D"));//domingo, 15 de junho de 2008
            Console.WriteLine(dateWithToString.ToString("f"));//domingo, 15 de junho de 2008 21:15
            Console.WriteLine(dateWithToString.ToString("F"));//domingo, 15 de junho de 2008 21:15:07
            Console.WriteLine(dateWithToString.ToString("g"));//15/06/2008 21:15
            Console.WriteLine(dateWithToString.ToString("G"));//15/06/2008 21:15:07
            Console.WriteLine(dateWithToString.ToString("m"));//15 de junho
            Console.WriteLine(dateWithToString.ToString("o"));//2008-06-15T21:15:07.0000000
            Console.WriteLine(dateWithToString.ToString("R"));//Sun, 15 Jun 2008 21:15:07 GMT
            Console.WriteLine(dateWithToString.ToString("s"));//2008-06-15T21:15:07
            Console.WriteLine(dateWithToString.ToString("t"));//21:15
            Console.WriteLine(dateWithToString.ToString("T"));//21:15:07
            Console.WriteLine(dateWithToString.ToString("u"));//2008-06-15 21:15:07Z
            Console.WriteLine(dateWithToString.ToString("U"));//segunda-feira, 16 de junho de 2008 00:15:07

        }
    
        public static string GetTimeNow()
        {
            return $"O momento de tempo atual é {DateTime.Now}";
        }
    }


}