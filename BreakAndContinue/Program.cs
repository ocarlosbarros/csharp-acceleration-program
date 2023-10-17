public class Program
{
    public static void Main()
    {
        string[] teachers = new string[] { "Joel", "Tess", "Marlene"};
        string[] students = new string[] { "Ellie", "Joel", "Abby"};

        foreach (var teacher in teachers)
        {
            Console.WriteLine($"Professor: {teacher}. Estudante:");
            foreach (var student in students)
            {
                if (teacher == student)
                    break;
                Console.WriteLine(student);
            }
        }

        int[] votes = new int[] { 1, 3, 5, 4, 1, 3, 1, 2};
        var count = 0;
        foreach (var vote in votes)
        {
            if (vote > 3)
                continue;
            count++;
        }
        Console.WriteLine($"{count} votos válidos");
    }
}