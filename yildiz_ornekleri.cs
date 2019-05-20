class Program
    {
        static void Main(string[] args)
        {
          int a = 10;
            for (int i = 1; i <=10;i++)
              {
                  for (int j = 11; j >i; j--)
                  {

                      Console.Write("*");

                  }
              
                  Console.WriteLine();
              } 
            int b = 1;

         for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j < a; j++)
                {
                    Console.Write("*");
                }
                a--;

                Console.WriteLine();
                for (int k = 1; k <= b; k++)
                {
                    Console.Write(" ");
                }
                b++;


            } 


           int m=9,n=1;
            for (int i = 1; i <= 10; i++)
            {

                for (int j=m ; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                m--;
                for (int k = 1; k <= n; k++)
                {
                    Console.Write("*");
                }
                n++;
                Console.WriteLine();


            }

 

               

                 int x = 10, y = 1;
                  for (int i = 1; i <= x; i++)
                  {
                      for (int j = 1; j <= y; j++)
                      {

                          Console.Write("*");
                   

                      }
                      y++;
                      Console.WriteLine();

                  }
         
                Console.Read();
            }
        }
