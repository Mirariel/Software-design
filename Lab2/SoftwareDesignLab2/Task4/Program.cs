class Program
{
    static void Main()
    {
        Virus parent = new Virus("Alpha", 0.5, 10, "Bacteria");
        Virus child1 = new Virus("Beta", 0.3, 5, "Bacteria");
        Virus child2 = new Virus("Gamma", 0.2, 3, "Bacteria");
        Virus grandchild = new Virus("Delta", 0.1, 1, "Bacteria");

        child1.AddChild(grandchild);
        parent.AddChild(child1);
        parent.AddChild(child2);

        Console.WriteLine("Оригінальне сімейство вірусів:");
        parent.ShowInfo();

        Virus clonedParent = (Virus)parent.Clone();
        Console.WriteLine("\nКлоноване сімейство вірусів:");
        clonedParent.ShowInfo();
    }
}