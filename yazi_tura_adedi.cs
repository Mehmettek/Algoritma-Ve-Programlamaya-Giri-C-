    class Program{
    static Random rastgele = new Random();
        static void yazıtura()
        {
            int yazıortura, yadet = 0,tadet=0 ;
            for (int i = 1; i <=100; i++)
            {
                yazıortura = rastgele.Next(0, 2);

                if (yazıortura == 0)
                {
                    yadet++;
                    Console.Write("Yazı\n");
                }
                else
                {
                    tadet++;
                    Console.Write("Tura\n");
                }
            }

            Console.Write("Yazıların Adedi:{0}\n", yadet);

            Console.Write("Turaların Adedi:{0}\n", tadet);
        }
        static void Main(string[] args)
        {
            yazıtura();
            Console.Read(); 
        }
        }
