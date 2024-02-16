class Motorcycle
{
    public double TopSpeed { get; set; }
    public bool CanDoWheelies { get; set; }
    public Engine Engine { get; set; } = new Engine();

    public void Drive(double distanceKm, double speed)
    {
        if (speed > TopSpeed)
            Console.WriteLine("Sua moto não pode ir tão rápido!");
        else if (!Engine.IsStarted)
            Console.WriteLine("Sua moto não está ligada!");
        else
        {
            var time = distanceKm / speed;
            Console.WriteLine($"Você chegou em {time} horas.");
        }
    }

    public void DoWheelie()
    {
        if (!CanDoWheelies)
            Console.WriteLine("Sua moto não pode fazer cavalinhos!");
        else if (!Engine.IsStarted)
            Console.WriteLine("Sua moto não está ligada!");
        else
            Console.WriteLine("Sua moto está fazendo um cavalinho!");
    }

    public void StartEngine() => Engine.Start();

    public void StopEngine() => Engine.Stop();
}