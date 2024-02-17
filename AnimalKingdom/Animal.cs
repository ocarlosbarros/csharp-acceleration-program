public abstract class Animal
{
    public abstract string ScientificName {get;}
    public abstract bool CanEatMeat {get;}
    public abstract bool CanEatVegetable {get;}

    public void Eat()
    {
        var animal = this.GetType().Name.ToLower();
        string food;

        if(CanEatMeat && CanEatVegetable)
        {
            var random = new Random();
            food = random.Next(0, 2) == 0 ? "carne" : "vegetais";
        }

        else if (CanEatMeat) food = "meat";
        else if (CanEatVegetable) food = "vegetables";
        else throw new InvalidOperationException($"{animal} não come nada!");

        Console.WriteLine($"O(a) {animal} está comendo um pouco de {food}.");
    }

} 