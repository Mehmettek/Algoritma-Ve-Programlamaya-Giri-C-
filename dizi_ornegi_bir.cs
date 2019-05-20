 
    public class Program
    {
        public static int[] sayılar=new int[10];
        static int dizitoplama(int[] a)
        {
           
            int topla=0;
           
            for (int i = 0; i <sayılar.Length; i++)
            {
               
                topla += sayılar[i];
            }
            return topla;
        }
        static void elemanatama(int[] dizi)
        {
            Random rastgele = new Random();
            for (int i = 0; i < sayılar.Length; i++)
            {
                sayılar[i] = rastgele.Next(1, 10001);
            }
        }
        static void yazdır()
        {
            Console.Write("---------------------10 elemanlı dizimizin kendisi---------------------\n");
            elemanatama(sayılar);
            foreach (int i in sayılar)
            {
                Console.Write(i+"\t");
            }
            Console.Write("\n------------------10 elemanlı dizimizin elemanları toplama------------------\n");
            Console.Write(dizitoplama(sayılar));
        }


        public static void Main(string[] args)
        {
            yazdır();
        }
    }
 
