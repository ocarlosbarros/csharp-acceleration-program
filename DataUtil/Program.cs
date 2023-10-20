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
            
        }
    
        public static string GetTimeNow()
        {
            return $"O momento de tempo atual é {DateTime.Now}";
        }
    }


}