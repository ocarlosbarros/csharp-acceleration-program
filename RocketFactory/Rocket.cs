namespace RocketFactory;

public class Rocket
{
    public string? Name {get; set;}
    int Fuel {get; set;} = 0;
    public decimal Cost {get;set;}

    public Rocket(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }
}
