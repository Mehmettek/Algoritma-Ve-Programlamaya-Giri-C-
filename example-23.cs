class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int[] x = new int[700];
            int adet = 0;
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rastgele.Next(1, 101);
                if (x[i] % 10 == 0)
                {
                    adet++;
                }

            }
            Console.Write("cevap " + adet);
            Console.Read();

        }
    }
