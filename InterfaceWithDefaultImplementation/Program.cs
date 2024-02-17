public class Program 
{
    public static void Main(string[] args)
    {
        Engine engine = new Engine();
        IStartable defaultImplementation = new Engine();

        engine.Stop();
        defaultImplementation.Start();
        defaultImplementation.Stop();

    }
}