class Program
    {
        static void Main(string[] args)
        {
            double[] x = new double[10];
            Random rastgele = new Random();
            Console.WriteLine("--------------DİZİMİZİN İLK HALİ-------------");
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rastgele.Next(1, 1001);
                Console.WriteLine("               " + x[i]);
                if (x[i] > 100 && x[i] < 500)
                {
                    
                    x[i] *= 1.10;
                }

            }
            Console.WriteLine("---------------100-500 ARALIGINDAKİ SAYILARIN %10 ARTIRILMIS HALİ--------------");
            foreach (int i in x)
            {
                Console.WriteLine("               "+ i);
            }
            Console.Read();
        }
    }
