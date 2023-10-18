public class Program
{
    public static void Main()
    {
        int numberOfPeople = 0;
        int numberOfChildren = 0;
        int age = 0;
        
        do
        {
            Console.WriteLine("Informe a idade da pessoa. Informe 0 para sair");
            age = Convert.ToInt32(Console.ReadLine());
            
            if  (age == 0) break;
            
            numberOfPeople++;

            if  (age < 18)  numberOfChildren++;

        }while(age > 0);
       
        double rateOfChildren = 0;

        if (numberOfPeople > 0) rateOfChildren = 100 * numberOfChildren / numberOfPeople;
        
        Console.WriteLine($"Existe {rateOfChildren} % de crianças");
    }
}