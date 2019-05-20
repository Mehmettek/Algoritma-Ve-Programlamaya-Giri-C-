//girilen sayının karesini alan fonsiyon

public class Program
    {
        public static void Main(string[] args)
        { int sayi;
            
            sayi = 5;
            karesiniAl(sayi);
            Console.ReadKey();
        }
        static void karesiniAl(int gelen)
        {
            int cevap;
            cevap = gelen * gelen;
            Console.WriteLine(cevap);
        }
        }
