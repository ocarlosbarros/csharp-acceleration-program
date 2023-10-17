using OtherDataTypes;

class Program
{
    public static void Main()
    {
        CardinalPointsEnum direction = CardinalPointsEnum.North;
        Console.WriteLine($"Ponto Cardeal: {direction}");

        //constants
        const string URL = "https://www.betrybe.com/";
        const int NUMBER_OF_ATTEMPTS_ALLOWED = 5;

        //variables with implict type
        var school = "Trybe";
        var semester = 1;
        var student = new { name = "Bruce Wayne", age = 22 };

        Console.WriteLine($"Olá! Me chamo {student.name} sou um estudante da escola {school} estou no {semester} º semestre e tenho {student.age} anos");
    }
}