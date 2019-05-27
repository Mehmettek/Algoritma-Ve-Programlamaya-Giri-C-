class Program
    {
        static void Main(string[] args)
        {

            double[] a = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int b;
            for (b = 0; b <= 9; b++)
            {

                if (a[b] >= 50)
                {
                    Console.WriteLine(a[b]);
                    continue;
                }
                a[b] = (a[b] * 0.10) + a[b];
                a[b] = a[b] + 50;
                Console.WriteLine(a[b]);
            }
            Console.Read();
        
        
        
        
        }
    }
