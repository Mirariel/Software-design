class Program
{
    static void Main(string[] args)
    {
        var ul = new LightElementNode("ul", DisplayType.Block, ClosingType.Normal);
        ul.AddClass("list");
        ul.AddClass("fancy-list");

        var li1 = new LightElementNode("li", DisplayType.Block, ClosingType.Normal);
        li1.AddClass("item");
        li1.AddChild(new LightTextNode("Перший елемент"));

        var li2 = new LightElementNode("li", DisplayType.Block, ClosingType.Normal);
        li2.AddClass("item");
        li2.AddChild(new LightTextNode("Другий елемент"));

        var li3 = new LightElementNode("li", DisplayType.Block, ClosingType.Normal);
        li3.AddClass("item");
        li3.AddChild(new LightTextNode("Третій елемент"));

        ul.AddChild(li1);
        ul.AddChild(li2);
        ul.AddChild(li3);

        Console.WriteLine("<!DOCTYPE html>");
        Console.WriteLine("<html>");
        Console.WriteLine("<body>");
        ul.RenderIndented(Console.Out, 1);
        Console.WriteLine("</body>");
        Console.WriteLine("</html>");
    }
}
