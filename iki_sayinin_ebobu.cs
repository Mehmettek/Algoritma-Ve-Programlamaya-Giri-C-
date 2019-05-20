class Program{

  static int ebob(int a, int b)
        {
            int c;
            while (a % b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return b;


        
        }
        static void sayıiste()
        {
            int a, b;
            Console.Write("Ebob u bulunacak 1.sayıyı Giriniz:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ebob u bulunacak 2.sayıyı Giriniz:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}  ve {1}  Sayıları için EBOB :{2}", a, b, ebob(a, b));
        }
        static void Main(string[] args)
        {
            sayıiste();
           
            Console.Read(); 
        }


}
