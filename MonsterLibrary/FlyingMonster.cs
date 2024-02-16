using MonsterLibrary;

public class FlyingMonster : Monster
{
    public bool IsFlying {get;set;} = false;

    public void Fly()
    {
        Console.WriteLine($"{Name} está voando agora!");
    }

    public void Descend()
    {
        Console.WriteLine($"{Name} agora está no chão!");
        IsFlying = false;
    }
}