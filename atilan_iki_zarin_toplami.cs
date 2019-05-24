 class Program
    {
     public static Random rastgele = new Random();
     static int zar1;
    static int zar2;
         static int[] tpl=new int[36000];
          
        static void zarat()
        { 
            Console.Write("----------------Zarların Toplamı---------------------\n");
            int toplam = 0;
            int sayac=0;
            while (sayac != 36000)
            {
                zar1 = rastgele.Next(1, 7);
                zar2 = rastgele.Next(1, 7);
                toplam = zar1 + zar2;
                    
                tpl[sayac] = toplam;

                Console.Write(tpl[sayac] + " ");
                if (sayac % 55 == 0)
                    Console.WriteLine();

                sayac++;
            }
        }
        static void Main(string[] args)
        {
         zarat();
            Console.Write("\n\n Dizinin Son Elemanı  " +tpl[35999]);
            Console.Read();
        }
}
