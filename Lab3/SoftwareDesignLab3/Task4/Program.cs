class Program
{
    static void Main(string[] args)
    {
        string allowedFile = "sample.txt";
        string blockedFile = "secret.txt";

        File.WriteAllText(allowedFile, "Hello\nWorld");
        File.WriteAllText(blockedFile, "This is secret!");

        Console.WriteLine("=== SmartTextChecker ===");
        ISmartTextReader checker = new SmartTextChecker();
        checker.ReadText(allowedFile);

        Console.WriteLine("\n=== SmartTextReaderLocker (regex: ^secret) ===");
        ISmartTextReader locker = new SmartTextReaderLocker("^secret");
        locker.ReadText(blockedFile);
        locker.ReadText(allowedFile);
    }
}
