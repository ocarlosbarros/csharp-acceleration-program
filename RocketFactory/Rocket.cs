namespace RocketFactory;

public class Rocket
{
    public string? Name {get; set;}
    int _fuel {get; set;} = 0;
    int _maxFuel = 5000;
    public decimal Cost {get;set;}

    public int FuelAsPercentage
    {
        get { return _fuel * 100 / _maxFuel;}
        set
        {
            if (value > 100 || value < 0)
                throw new ArgumentOutOfRangeException();
            
            _fuel = (value * _maxFuel) / 100;
        }
    }

    public Rocket(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }
}
