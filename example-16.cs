  class Program
    {
        static void Main(string[] args)
        {
            int a = 0, p = 0;
            int[] x = { 10, 29, 30, 100, 56, 50 };
            for (int i = 0; i <= x.Length - 1; i++)
            {
                if (x[i] % 10 == 0)
                {
                    p++;
                }
            }
            Console.Write("Sonuc:" + p);
            Console.Read();
        }
    }
