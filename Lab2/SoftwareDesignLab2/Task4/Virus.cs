class Virus : ICloneable
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }
    public string Type { get; set; }
    public List<Virus> Children { get; set; } = new List<Virus>();

    public Virus(string name, double weight, int age, string type)
    {
        Name = name;
        Weight = weight;
        Age = age;
        Type = type;
    }

    public void AddChild(Virus child)
    {
        Children.Add(child);
    }

    public object Clone()
    {
        Virus clone = new Virus(Name, Weight, Age, Type);
        foreach (var child in Children)
        {
            clone.AddChild((Virus)child.Clone());
        }
        return clone;
    }

    public void ShowInfo(int level = 0)
    {
        Console.WriteLine(new string('-', level * 2) + $"> {Name}, {Type}, Вага: {Weight}г, Вік: {Age} днів");
        foreach (var child in Children)
        {
            child.ShowInfo(level + 1);
        }
    }
}
