public class Program
{
    public static void Main()
    {
        UseWhile();
        Console.WriteLine("=======================================");
        UseDoWhile();
        
    }

    public static void UseWhile()
    {
        int count = 0;
        while (count < 10){
            Console.WriteLine($"count {count}");
            count++;
        }
    }

    public static void UseDoWhile()
    {
        int count = 0;
        do
        {
            Console.WriteLine("count " + count);
            count++;
        }
        while (count < 10);
    }
}