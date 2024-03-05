public class DigitalAccount : Account
{
    public OperatingSystem AccountCreationOS { get; }
    public DateTime AccountCreationDate { get; } = DateTime.Now;

    public DigitalAccount(Customer owner, OperatingSystem OS) : base(owner) {
        AccountCreationOS = OS;
    }

    public override void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"New balance is {Balance}");
    }
}