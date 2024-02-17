public class Dog : Animal
{
    public override string EatingHabits { get; set; } = "Carnívoro";
    public override string Habitat { get; set; } = "Casa de humanos";

    public override void Feed()
    {
        Console.WriteLine("Alimentando o cachorro.");
    }

    public override void Move()
    {
        Console.WriteLine("Cachorro está caminhando.");
    }

    public void Bark()
    {
        Console.WriteLine("Woof!");
    }
}