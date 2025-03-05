using ClassLibrary_Task5;
using System.Reflection.Emit;

class Program
{
    static void Main()
    {
        CharacterDirector director = new CharacterDirector();

        Character hero = director.CreateHero(new HeroBuilder());
        Character enemy = director.CreateEnemy(new EnemyBuilder());

        Console.WriteLine("Hero:");
        hero.ShowInfo();
        Console.WriteLine("\nEnemy:");
        enemy.ShowInfo();
    }
}