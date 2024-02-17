using System.Reflection.Metadata.Ecma335;

public class Person : IGreeter
{
    private readonly string _name;

    public Person(string name) => _name = name;
    public void SayGreeting(string greeting)
    {
        Console.WriteLine($"{greeting}{_name}!");
    }
}