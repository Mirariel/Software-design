using System.Text.RegularExpressions;

public class SmartTextReaderLocker : ISmartTextReader
{
    private SmartTextReader _reader = new SmartTextReader();
    private Regex _blockedPattern;

    public SmartTextReaderLocker(string regexPattern)
    {
        _blockedPattern = new Regex(regexPattern, RegexOptions.IgnoreCase);
    }

    public char[][] ReadText(string path)
    {
        if (_blockedPattern.IsMatch(path))
        {
            Console.WriteLine("Access denied!");
            return null;
        }

        return _reader.ReadText(path);
    }
}
