class Program
    {
        static void Main(string[] args)
        {

            int[,] sayi = new int[3, 3];
            int a=0;
        
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a = a + 1;
                    sayi[i, j] = a; }
            }
            for (int m = 0; m < 3; m++)
            { 
                for(int h=0;h<3;h++)
                {  
                                
                Console.WriteLine(sayi[m,h]);
                }
                 }
            Console.Read();

        }
    }
