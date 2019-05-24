 class Program
    {
        static void Main(string[] args)
        {
            int sayi, b = 1, c = 1;
            string s;
            Console.WriteLine("bir sayı giriniz:");
            s = Console.ReadLine();
            sayi = int.Parse(s);
            while (sayi / b > 9)
            {
                b = b * 10;
                c++;

            }
            Console.WriteLine(c + " basamaklı");
            Console.Read();
        }
    }
