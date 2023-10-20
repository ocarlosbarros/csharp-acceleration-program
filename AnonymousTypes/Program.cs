namespace AnonymousTypes
{
    public class Program
    {
        public static void Main()
        {
            /*  Anonymous types
                Is a set of read-only properties into a single object without define a type first
                */
            var myAnonymousType = new { Amount = 42, Message = "Olá",  Value = 3.95};
            Console.WriteLine(myAnonymousType.Amount);
            Console.WriteLine(myAnonymousType.Message);
            Console.WriteLine(myAnonymousType.Value);       
        }
    }
}