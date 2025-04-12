public class LightElementNode : LightNode
{
    public string TagName { get; set; }
    public DisplayType Display { get; set; }
    public ClosingType Closing { get; set; }
    public List<string> CssClasses { get; set; } = new();
    public List<LightNode> Children { get; set; } = new();

    public LightElementNode(string tagName, DisplayType display, ClosingType closing)
    {
        TagName = tagName;
        Display = display;
        Closing = closing;
    }

    public void AddClass(string className)
    {
        CssClasses.Add(className);
    }

    public void AddChild(LightNode node)
    {
        Children.Add(node);
    }

    public override string InnerHTML =>
        string.Join("", Children.Select(child => child.OuterHTML));

    public override string OuterHTML
    {
        get
        {
            string classAttr = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
            if (Closing == ClosingType.SelfClosing)
            {
                return $"<{TagName}{classAttr}/>";
            }
            else
            {
                return $"<{TagName}{classAttr}>{InnerHTML}</{TagName}>";
            }
        }
    }

    public override void RenderIndented(TextWriter writer, int indent = 0)
    {
        string indentStr = new string(' ', indent * 2);
        string classAttr = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";

        if (Closing == ClosingType.SelfClosing)
        {
            writer.WriteLine($"{indentStr}<{TagName}{classAttr}/>");
            return;
        }

        writer.WriteLine($"{indentStr}<{TagName}{classAttr}>");

        foreach (var child in Children)
        {
            child.RenderIndented(writer, indent + 1);
        }

        writer.WriteLine($"{indentStr}</{TagName}>");
    }
}
