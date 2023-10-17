public class Program
{
    public static void Main(){

        Console.WriteLine("Informe um inteiro com o número de lados do polígono");
        string? userEntry = Console.ReadLine();
        bool validResponse = Int32.TryParse(userEntry, out var sideCount);

        if (validResponse && sideCount >= 3)
        {
            string response = IdentifyPolygon(sideCount);
            string complexity = string.Empty;

            if (sideCount < 6){
                complexity = "básico";
            }
            else {
                complexity = "complexo";
            }

            Console.WriteLine($"O polígono com {sideCount} lados é classificado como: {response}");
            Console.WriteLine($"O polígono {response} é classificado como: {complexity}");

        }
        else {
            Console.WriteLine("Não é um polígono.");
        }
    }

    public static string IdentifyPolygon(int sideCount)
    {
        var name = string.Empty;

        switch (sideCount)
        {
            case 3:
                name = "Triângulo";
                break;
            case 4:
                name = "Quadrado";
                break;
            case 5:
                name = "Pentágono";
                break;
            case 6:
                name = "Hexágono";
                break;
            default:
                name = "não identificado.";
                break;
        }
        return name;
    }
}
