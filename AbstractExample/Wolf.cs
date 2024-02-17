public class Wolf : Animal
{
    public override string EatingHabits { get; set; } = "Carnívoro";
    public override string Habitat { get; set; } = "Floresta";

    public override void Feed()
    {
        Console.WriteLine("Alimentando o lobo.");
    }

    public override void Move()
    {
        Console.WriteLine("O Lobo está caminhando.");
    }
    
}