class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        order.PayType = PaymentType.Credit;

        Console.WriteLine("Crédito " + (int) PaymentType.Credit);
        Console.WriteLine("Débito " + (int) PaymentType.Debit);
        Console.WriteLine("Order " + order.PayType);
    }
}