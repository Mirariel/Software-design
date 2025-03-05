using ClassLibrary_Task2;
using ClassLibrary_Task2.Interface;
class Program
{
    static void Main()
    {
        ITechFactory iproneFactory = new IProneFactory();
        ITechFactory kiaomiFactory = new KiaomiFactory();
        ITechFactory balaxyFactory = new BalaxyFactory();

        Console.WriteLine("IProne:");
        Console.WriteLine(iproneFactory.CreateLaptop().GetDeviceType());
        Console.WriteLine(iproneFactory.CreateSmartphone().GetDeviceType());

        Console.WriteLine("\nKiaomi:");
        Console.WriteLine(kiaomiFactory.CreateNetbook().GetDeviceType());
        Console.WriteLine(kiaomiFactory.CreateEBook().GetDeviceType());

        Console.WriteLine("\nBalaxy:");
        Console.WriteLine(balaxyFactory.CreateLaptop().GetDeviceType());
        Console.WriteLine(balaxyFactory.CreateSmartphone().GetDeviceType());
    }
}