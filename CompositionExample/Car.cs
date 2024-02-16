public class Car
{
    public double TopSpeed {get;set;}
    public bool IsAutomatic {get;set;}
    public int NumbersOfSeats {get;set;}

    public Engine Engine {get;set;} = new Engine();

    // public int EngineHorsePower {get;set;}
    // public int EngineTorque {get;set;}
    // public int EngineCapacity {get;set;}
    // public bool IsEngineStarted {get;set;}


    public void Drive(double distanceKm, double speed )
    {
        if (speed > TopSpeed)
            Console.WriteLine("Seu carro não pode ir tão rápido!");
        else if (!Engine.IsStarted)
            Console.WriteLine("Seu carro não está ligado!");
        else
        {
            var time = distanceKm / speed;
            Console.WriteLine($"Você chegou em {time} horas.");
        }
    }

    // public void StartEngine()
    // {
    //     if (IsEngineStarted)
    //         Console.WriteLine("O motor já está ligado!");
    //     else
    //         IsEngineStarted = true;
    // }

    public void StartEngine() => Engine.Start();

    // public void StopEngine()
    // {
    //     if (!IsEngineStarted)
    //         Console.WriteLine("O motor já está parado!");
    //     else
    //         IsEngineStarted = false;
    // }

    public void StopEngine() => Engine.Stop();
}