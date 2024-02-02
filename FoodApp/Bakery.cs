public class Bakery
{
    public string Name { get; set; }
    public string Owner { get; set; }

    public Bakery(string name, string owner)
    {
        Name = name;
        Owner = owner;
    }

    public void BakeCake()
    {
        Console.WriteLine($"A padaria {Name} está fazendo um bolo...");
    }

    public static Bakery ConvertFromRestaurant(Restaurant restaurant, string name = "")
{
    return new Bakery(
        string.IsNullOrEmpty(name) ? restaurant.Name : name,
        restaurant.Owner
    );
}
}