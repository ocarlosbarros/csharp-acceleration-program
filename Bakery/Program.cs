class Program
{
    public static void Main(string[] args)
    {
        var newBakery = new Bakery();

        var bread = newBakery.fabricatedBread(10);
        
        Console.WriteLine(bread.Weight);
        
        // bread.Type = "Brown";//set validation
        Console.WriteLine(bread.Type);

        
        var cake = newBakery.fabricateChocolateCake("10");
        Console.WriteLine(cake.Flavour);
        Console.WriteLine(cake.Size);
    }
}