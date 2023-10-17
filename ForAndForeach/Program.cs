public class Program 
{
    public static void Main()
    {
        UseFor();
        Console.WriteLine("===========================");
        UseForeach();
    }

    public static void UseFor()
    {
        for (int count = 0; count < 3; count++)
        {
            Console.WriteLine("numero: " + count);
        }
    }

    public static void UseForeach()
    {
        string[] names = new string[] { "Odin", "Thor", "Loki" };
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}