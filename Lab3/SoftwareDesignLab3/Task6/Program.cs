class Program
{
    static void Main()
    {
        var lines = new List<string>
        {
            "ACT V",
            "Scene I. Mantua. A Street.",
            "Scene II. Friar Lawrence’s Cell.",
            "Scene III. A churchyard; in it a Monument belonging to the Capulets.",
            "",
            "  Dramatis Personæ",
            "ESCALUS, Prince of Verona.",
            "MERCUTIO, kinsman to the Prince, and friend to Romeo.",
            "PARIS, a young Nobleman, kinsman to the Prince.",
            "Page to Paris."
        };

        var factory = new HtmlElementFlyweightFactory();
        var body = new LightElementNode("div", DisplayType.Block, ClosingType.Normal);

        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;

            string tag = body.Children.Count == 0 ? "h1" :
                         line.Length < 20 ? "h2" :
                         char.IsWhiteSpace(line[0]) ? "blockquote" : "p";

            var baseElement = factory.GetElement(tag);
            var node = new LightElementNode(baseElement.TagName, baseElement.Display, baseElement.Closing);
            node.CssClasses = new List<string>(baseElement.CssClasses);
            node.AddChild(new LightTextNode(line.Trim()));
            body.AddChild(node);
        }

        Console.WriteLine("<!DOCTYPE html>");
        Console.WriteLine("<html>");
        Console.WriteLine("<body>");
        body.RenderIndented(Console.Out, 1);
        Console.WriteLine("</body>");
        Console.WriteLine("</html>");

        Console.WriteLine($"\nВикористано унікальних HTML-тегів (Flyweight): {factory.Count}");
        Console.WriteLine($"Кількість HTML-вузлів у дереві: {body.Children.Count}");
    }
}