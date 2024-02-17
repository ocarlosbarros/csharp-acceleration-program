public class BluetoothPlayer : IPlayer
{
    public void Play(string mediaName)
    {
        Console.WriteLine($"O bluetooth está conectado ao {mediaName}");
    }
}