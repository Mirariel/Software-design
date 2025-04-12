public class SmartTextChecker : ISmartTextReader
{
    private SmartTextReader _reader = new SmartTextReader();

    public char[][] ReadText(string path)
    {
        Console.WriteLine($"Opening file: {path}");
        char[][] data = _reader.ReadText(path);
        Console.WriteLine($"File read successfully.");

        int lineCount = data.Length;
        int charCount = data.Sum(row => row.Length);
        Console.WriteLine($"Lines: {lineCount}, Characters: {charCount}");

        Console.WriteLine("Closing file.");
        return data;
    }
}