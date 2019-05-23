class Program
    {
        static void Main(string[] args)
        {
            int x = 1,n;
            Console.Write("N i giriniz");
            n = Convert.ToInt32(Console.ReadLine());
            while(x<=n)
            {
                Console.WriteLine(x * x);
                x = x + 1;
            }
            Console.Read();
       
