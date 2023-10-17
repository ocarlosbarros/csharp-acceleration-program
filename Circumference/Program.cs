public class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe o raio de um círculo (deve ser um número inteiro)");
        string? response = Console.ReadLine();
        int radius = 0;
        var canConvert = Int32.TryParse(response, out radius);

        if(canConvert)
        {
            const double PI = 3.14159;

            double circumference = PI * (2 * radius);

            Console.WriteLine("A circunferência de um circulo com raio "+ radius + " é igual a " + circumference);
        }
        else
        {
            Console.WriteLine("O texto digitado não é um número inteiro.");
        }
    }
}