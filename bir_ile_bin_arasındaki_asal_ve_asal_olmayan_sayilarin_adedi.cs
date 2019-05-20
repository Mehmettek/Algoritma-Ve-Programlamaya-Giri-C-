public class Program
    {
         static int adet = 2;
     static  ArrayList asalsayılar=new ArrayList();
       static ArrayList asalolmayanlar = new ArrayList();
         
        static int asalsayıadedi = 2, asalsayıolmayanlarınadedi = 0;
        static void asalmı()
        {
            asalsayılar.Add(1);

            asalsayılar.Add(2);
            bool kontrol = false;

            for (int i = 3; i <= 1000; i++)
            {
                for (int j = 2; j < i; j++)
                {

                    if (i % j == 0)
                    {
                       
                        kontrol = false;
                        break;
                    }
                    else
                    {
                       
                        kontrol = true;
                    }

                }
                if (kontrol == false)
                {
                    asalolmayanlar.Add(i);
                    asalsayıolmayanlarınadedi++;
                    
                }
                else
                {
                    asalsayılar.Add(i);
                    asalsayıadedi++;
                   
                }


            }
           
        }
        static void yaz()
        {
            int sayac = 0;
            Console.Write("----------------------1-1000 Arasındaki Asal Sayılar-----------------\n");
            foreach (int i in asalsayılar)
            {
                sayac++;
                Console.Write(i + " ");
                if (sayac % 20 == 0)
                    Console.WriteLine();
            }
            Console.Write("\nAdedi:{0}", asalsayıadedi);


            Console.Write("\n\n\n----------------------1-1000 Arasındaki Asal Olmayan Sayılar-----------------\n");
            sayac = 0;
            foreach (int i in asalolmayanlar)
            {
                sayac++;
                Console.Write(i + " ");
                if (sayac % 20 == 0)
                    Console.WriteLine();
            }
            Console.Write("\nAdedi:{0}",asalsayıolmayanlarınadedi);
        
        }

   public static void Main(string[] args)
        {
            bool kontrol = false;
           int adet1 = 2;
              asalmı();
            yaz();
        }
    }
