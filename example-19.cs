namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("sayı giriniz:");
            sayi = Int32.Parse(Console.ReadLine());
            while (sayi > 0)
            {
                Console.WriteLine(sayi % 10);
                sayi = sayi / 10;
            }
            
            Console.Read();
        }
    }
}
