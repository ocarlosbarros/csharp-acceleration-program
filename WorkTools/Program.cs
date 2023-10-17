using WorkTools;

public class Program
{
    public static void Main()
    {
        int[] productsList = new int[] { 1, 2, 3, 2, 2, 4, 1, 3, 4, 4, 4, 4, 4 };
        
        int timesSold = NumbersTools.CountOf(productsList, 1);
        Console.WriteLine($"Vezes vendidas: {timesSold}");

        int salesposition = NumbersTools.IndexOf(productsList, 4);
        Console.WriteLine($"Posição de vendas: {salesposition}");

        int quantityProductsForSales = TestNumbersTools.CountEvenNumbers(productsList);
        Console.WriteLine($"Quantidade de lotes prontos para venda: {quantityProductsForSales}");

    }
}

