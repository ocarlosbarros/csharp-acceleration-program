class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        order.PayType = PaymentType.Credit;

        
        Console.WriteLine("Order " + order.PayType);


        Console.WriteLine("String Crédito: " + PaymentType.Credit + " Valor Crédito: " + (int)PaymentType.Credit);
        Console.WriteLine("String Débito: " + PaymentType.Debit  + " Valor Débito: " + (int)PaymentType.Debit);
        Console.WriteLine("String InCash: " + PaymentType.InCash  + " Valor em dinheiro: " + (int)PaymentType.InCash);
        Console.WriteLine("String InParts: " + PaymentType.InParts  + " Valor parcelado: " + (int)PaymentType.InParts);

        //True
        Console.WriteLine(System.Enum.IsDefined(typeof(PaymentType), 1));
        Console.WriteLine(System.Enum.IsDefined(typeof(PaymentType), 2));

        //False
        Console.WriteLine(System.Enum.IsDefined(typeof(PaymentType), 0));
        Console.WriteLine(System.Enum.IsDefined(typeof(PaymentType), 3));

        //String isDefined = True
        Console.WriteLine(System.Enum.IsDefined(typeof(PaymentType), "Credit"));
        Console.WriteLine(System.Enum.IsDefined(typeof(PaymentType), "Debit"));
        Console.WriteLine(System.Enum.IsDefined(typeof(PaymentType), "InCash"));
        
        
        //False
        Console.WriteLine(System.Enum.IsDefined(typeof(PaymentType), "credit"));
        Console.WriteLine(System.Enum.IsDefined(typeof(PaymentType), "debit"));
    }
}