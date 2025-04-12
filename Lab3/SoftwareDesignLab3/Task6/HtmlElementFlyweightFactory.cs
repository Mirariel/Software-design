public class HtmlElementFlyweightFactory
{
    private Dictionary<string, LightElementNode> _elements = new();

    public LightElementNode GetElement(string tagName)
    {
        if (!_elements.ContainsKey(tagName))
        {
            var node = new LightElementNode(tagName, DisplayType.Block, tagName == "img" ? ClosingType.SelfClosing : ClosingType.Normal);
            _elements[tagName] = node;
        }

        return _elements[tagName];
    }

    public int Count => _elements.Count;
}