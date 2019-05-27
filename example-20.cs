class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int n;
            Console.Write(" Lütfen Dizinin Kac Elemanlı Olacagını Giriniz: ");
            n = int.Parse(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                x[i] = rastgele.Next(1, 100);
                                    
            }
            int k = 0;
            foreach (int i in x)
            {

                Console.WriteLine((k+1) + ".Eleman " + i);
                k++;
            }
            
            Console.Read();
        }
    }
