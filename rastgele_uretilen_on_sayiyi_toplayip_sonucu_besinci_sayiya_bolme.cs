using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int sıra=0, tpl = 0, sayi,sonuc=0;
            for (int i = 1; i <= 10; i++)
            {
               
                sayi = rastgele.Next(1, 100);
                tpl += sayi;
                if (i == 5)
                {
                    sıra = sayi;
                }

            }
            Console.Write(sıra);
            Console.Write("Sonuc=" + tpl / sıra);
            Console.Read();





        }
    }
}
