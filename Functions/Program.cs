public class Program
{
    public static void Main(string[] args)
    {
        /*
            Functions: Encapsulating a piece of code under a nomenclature
            may or may not return.
            */

        //return void example
        SendEmail();
        

        string BMI = CalculateBMI(78.5, 1.81);
        Console.WriteLine(BMI);

        int age = CalculateAgeByYear(1991);
        Console.WriteLine(age);

        var isOfLegalAge = ValidateComingOfAge(age);
        Console.WriteLine(isOfLegalAge);

        var child = ValidateComingOfAge(2015);
        Console.WriteLine(child);

    }

    public static void SendEmail(){
        //some code
        return;
    }

    public static string CalculateBMI(double weight, double height)
    {
        double BMI = weight / (height * height);
        return BMI.ToString("N2");
    }

    public static int CalculateAgeByYear(int yearOfBirth)
    {
        return DateTime.Now.Year - yearOfBirth;
    }

    public static bool ValidateComingOfAge(int age) 
    {
    return age >= 18;
    }
}