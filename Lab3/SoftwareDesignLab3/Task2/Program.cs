class Program
{
    static void Main(string[] args)
    {
        IHero warrior = new Warrior();
        warrior = new Sword(warrior);
        warrior = new Armor(warrior);
        warrior = new Artifact(warrior);

        Console.WriteLine(warrior.GetDescription());
        Console.WriteLine("Power: " + warrior.GetPower());

        Console.WriteLine();

        IHero mage = new Mage();
        mage = new Artifact(mage);
        mage = new Artifact(mage);

        Console.WriteLine(mage.GetDescription());
        Console.WriteLine("Power: " + mage.GetPower());

        Console.WriteLine();

        IHero palladin = new Palladin();
        palladin = new Sword(palladin);
        palladin = new Sword(palladin);
        palladin = new Armor(palladin);

        Console.WriteLine(palladin.GetDescription());
        Console.WriteLine("Power: " + palladin.GetPower());
    }
}