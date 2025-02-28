using ClassLibrary;

class Program
{
    static void Main()
    {
        Console.WriteLine("Тестування функціональності:");

        Money price1 = new Money(10, 50);
        Product product1 = new Product("Яблуко", price1, "Фрукти");
        Money price2 = new Money(5, 75);
        Product product2 = new Product("Банан", price2, "Фрукти");

        Warehouse warehouse = new Warehouse();
        warehouse.AddProduct(product1);
        warehouse.AddProduct(product2);

        Console.WriteLine("Стан складу до зміни цін:");
        Reporting.InventoryReport(warehouse);

        Console.WriteLine("Зменшуємо ціну яблука на 100 копійок...");
        product1.DecreasePrice(100);

        Console.WriteLine("Стан складу після зміни цін:");
        Reporting.InventoryReport(warehouse);
    }
}