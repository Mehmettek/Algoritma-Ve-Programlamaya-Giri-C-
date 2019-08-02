   public class Program
    {
        public static void Main(string[] args)
        {
            int a=10;
            int b=33;
            
            int cift=0;
            Console.Write("1. sayıyı giriniz:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            b = Convert.ToInt32(Console.ReadLine());
            
            for(int i=a;i<b;i++) {
                a++;
            if(a%2==0)
                cift++;
             }
            Console.WriteLine("İki Sayı Arasındaki Çift Sayıların Adedi {0}",cift);
        }
    }
