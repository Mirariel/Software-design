namespace ClassLibrary
{
    public class Money
    {
        public int WholePart { get; set; }
        public int Cents { get; set; }

        public Money(int whole, int cents)
        {
            WholePart = whole;
            Cents = cents;
        }

        public void Display()
        {
            Console.WriteLine($"{WholePart}.{Cents:D2}");
        }
    }
}
