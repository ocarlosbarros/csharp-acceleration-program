using RocketFactory;

class Program
{
    static void Main(string[] args)
    {
        var rocket = new Rocket("Apollo 11", 355000000m);
        var secondRocket = new Rocket("Falcon 9", 90000000m);


        Console.WriteLine(rocket.Name);
        Console.WriteLine(secondRocket.Name);
        Console.WriteLine(rocket.Cost);


    }

}
