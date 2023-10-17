public class Program
{
    public static void Main(){

        Console.WriteLine("Informe um inteiro com o número de lados do polígono");
        string? userEntry = Console.ReadLine();
        bool validResponse = Int32.TryParse(userEntry, out var sideCount);

        if (validResponse)
        {
            string response = IdentifyPolygon(sideCount);
            Console.WriteLine(response);
        }
        
        
    }

    public static string IdentifyPolygon(int sideCount)
    {
        var name = string.Empty;

        switch (sideCount)
        {
            case < 3:
                name = "Não é um polígono";
                break;
            case 3:
                name = "Triângulo";
                break;
            case 4:
                name = "Quadrado";
                break;
            case 5:
                name = "Pentágono";
                break;
            default:
                name = "Polígono não identificado";
                break;
        }
        return name;
    }
}
