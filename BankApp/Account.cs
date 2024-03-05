public class Account
{
    public decimal _balance;

    public Customer Owner { get; set; }
    public decimal Balance
    {
        get => _balance;
        set
        {
            if (value < 0)
                throw new ArgumentException("O Saldo não pode ser negativo!");
            _balance = value;
        }
    }

    public Account(Customer owner)
    {
        Owner = owner;
    }

    public virtual void Deposit(decimal amount) => Balance += amount;
    public void Withdraw(decimal amount) => Balance -= amount;
}