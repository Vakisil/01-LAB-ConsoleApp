namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Proizvod proizvod1 = new Proizvod("laptop", 1200.50m, 10);
            Proizvod proizvod2 = new Proizvod("racunLO", 1200.50M, 20);
            proizvod1.IspisiInformacije();
            proizvod2.IspisiInformacije();
        }
    }
}