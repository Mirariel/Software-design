using Task3;
class Program
{
    static void Main()
    {
        Authenticator auth1 = Authenticator.Instance;
        Authenticator auth2 = Authenticator.Instance;

        Console.WriteLine(ReferenceEquals(auth1, auth2) ? "Один і той самий екземпляр" : "Різні екземпляри");

        auth1.Authenticate("user123", "password");
        auth2.Authenticate("user321", "password");
    }
}