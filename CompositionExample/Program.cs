public class Program 
{
    public static void Main(string[] args)
    {
        Car car = new Car { TopSpeed = 250, IsAutomatic = false, NumbersOfSeats = 5, Engine = { Horsepower = 200, Torque = 100, Capacity = 50, IsStarted = false } };

        car.StartEngine();
        car.Drive(1000, 90);
        car.StopEngine();

    }
}