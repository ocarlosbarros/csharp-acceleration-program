public interface IStartable 
{
    public void Start()
    {
        Console.WriteLine("Item started!");
    }

    public void Stop()
    {
        Console.WriteLine("Item stoped!");
    }
}