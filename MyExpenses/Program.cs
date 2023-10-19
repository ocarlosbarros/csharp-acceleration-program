public class Program
{
    public static void Main(string[] args)
    {
        int[] expensesCost;
        
        Console.WriteLine("Entre com o número de despesas: ");
        int numberOfExpenses = GetNumberOfExpenses();

        expensesCost = new int[numberOfExpenses];

        for (int index = 0; index < numberOfExpenses; index+= 1)
        {
            expensesCost[index] = GetExpenseCostFromUser();
        }

        int totalExpenses = 0;

        for (int index = 0; index < numberOfExpenses; index += 1)
        {   
            totalExpenses += expensesCost[index];
        }

        Console.WriteLine($"O total das despesas são: {totalExpenses}");
    }

    public static int GetNumberOfExpenses()
    {
        string? entry = Console.ReadLine();
        int entryInt = Convert.ToInt32(entry);
        return entryInt;
    }

    public static int GetExpenseCostFromUser()
    {
        Console.WriteLine("Entre com o valor da despesa em R$");
        string? entry = Console.ReadLine();
        int expenseValue = Convert.ToInt32(entry);
        return expenseValue;
    }

}