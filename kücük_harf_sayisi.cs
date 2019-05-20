class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Bir satır yazıp Entera basınız:");
            string s = Console.ReadLine();
            Console.WriteLine("Küçük Harf Sayısı: {0}", kücükharfsay(s));     
          
            Console.Read();

        }
        static int kücükharfsay(string str)
        {
            int adet=0;
            foreach(char harf in str)
            {
                if (char.IsLower(harf))
                    adet++;

            }
                return adet;

        }
    }
