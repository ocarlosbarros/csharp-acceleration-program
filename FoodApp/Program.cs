class Program
{
    public static void Main(string[] args)
    {
        var myRestaurant = new Restaurant("Siri Cascudo", "Sirigueijo ");

        var myBakery = Bakery.ConvertFromRestaurant(myRestaurant, "Confeitaria do Siri");

        Console.WriteLine(myRestaurant.Name);
        Console.WriteLine(myBakery.Name);

        Console.WriteLine(myRestaurant.Owner);
        Console.WriteLine(myBakery.Owner);
    }
}