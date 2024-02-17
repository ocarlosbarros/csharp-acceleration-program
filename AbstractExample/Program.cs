using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        Wolf wolf = new Wolf();
        FeedAnimal(wolf);

        FeedDog();


    }

    public static void FeedAnimal(Animal animal)
    {
            animal.Feed();
    }

    public static void FeedDog()
    {
    Dog dog = new Dog();
    FeedAnimal(dog);
    }
}