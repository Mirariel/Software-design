class Program
{
    static void Main(string[] args)
    {
        Logger consoleLogger = new Logger();
        consoleLogger.Log("Це звичайне повідомлення.");
        consoleLogger.Warn("Це попередження.");
        consoleLogger.Error("Це помилка.");

        Logger fileLogger = new FileLoggerAdapter("log.txt");
        fileLogger.Log("Файл: повідомлення лог.");
        fileLogger.Warn("Файл: попередження.");
        fileLogger.Error("Файл: помилка.");

        Console.WriteLine("Логування завершено.");
    }
}
