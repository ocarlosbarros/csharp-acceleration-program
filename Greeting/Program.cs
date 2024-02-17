public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person("Peter");
        Placard placard = new Placard();
        person.SayGreeting("Olá eu sou ");
        placard.SayGreeting("Kansas City Chiefs 25  - San Francisco 49ers 22");
    }
}