namespace MonsterLibrary;

public class Monster
{
    public string Name {get;set;}
    public Armor Armor {get;set;}

    public void Attack()
    {
        Console.WriteLine($"{Name} fez um ataque");
    }

    public void Move(string location)
    {
        Console.WriteLine($"{Name} mudou-se para {location}");
    }

}
