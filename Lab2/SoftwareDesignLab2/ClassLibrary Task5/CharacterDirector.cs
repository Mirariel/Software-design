using ClassLibrary_Task5;

public class CharacterDirector
{
    public Character CreateHero(ICharacterBuilder builder)
    {
        return builder.SetName("knight")
                      .SetHeight(185)
                      .SetBuild("Athletic")
                      .SetHairColor("Blonde")
                      .SetEyeColor("Blue")
                      .SetOutfit("Armor")
                      .AddToInventory("Sword")
                      .AddToInventory("Shield")
                      .AddAction("Protect people")
                      .Build();
    }

    public Character CreateEnemy(ICharacterBuilder builder)
    {
        return builder.SetName("Dark Lord")
                      .SetHeight(200)
                      .SetBuild("Mighty")
                      .SetHairColor("Black")
                      .SetEyeColor("Red")
                      .SetOutfit("Cloak of Darkness")
                      .AddToInventory("Dark Staff")
                      .AddAction("Destroy Cities")
                      .Build();
    }
}