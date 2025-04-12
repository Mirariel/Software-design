public class Sword : HeroDecorator
{
    public Sword(IHero hero) : base(hero) { }

    public override string GetDescription()
    {
        return base.GetDescription() + " + Sword";
    }

    public override int GetPower()
    {
        return base.GetPower() + 5;
    }
}

public class Armor : HeroDecorator
{
    public Armor(IHero hero) : base(hero) { }

    public override string GetDescription()
    {
        return base.GetDescription() + " + Armor";
    }

    public override int GetPower()
    {
        return base.GetPower() + 3;
    }
}

public class Artifact : HeroDecorator
{
    public Artifact(IHero hero) : base(hero) { }

    public override string GetDescription()
    {
        return base.GetDescription() + " + Artifact";
    }

    public override int GetPower()
    {
        return base.GetPower() + 7;
    }
}
