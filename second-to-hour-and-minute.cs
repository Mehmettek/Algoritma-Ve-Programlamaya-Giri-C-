 class Program
    {
        static void Main(string[] args)
        {
            int sa, dk, sn;
            Console.Write("Saniye degerini giriniz:");
            sn = int.Parse(Console.ReadLine());
            sa = sn / 3600;
            sn = sn - (sa * 3600);
            dk = sn / 60;
            sn = sn - (dk * 60);
            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", sa, dk, sn);
            Console.Read();
        }
    }
