using System.Reflection.Metadata.Ecma335;

public class Placard : IGreeter
{

    public void SayGreeting(string greeting)
    {
        Console.WriteLine(greeting);
    }
}