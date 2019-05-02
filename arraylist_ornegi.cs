using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GitHub_Comit_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();

            Console.WriteLine("A1 in eleman sayısı sudur:" + a1.Count);

            a1.Add('A');
            a1.Add('D');
            a1.Add('C');
            a1.Add('E');
            a1.Add('F');
            a1.Add('G');

            Console.WriteLine("A1 in eleman sayısı artık sudur:" + a1.Count);

            Console.WriteLine("A1 in kendisi sudur");

            for (int i = 0; i < a1.Count; i++)
                Console.Write(a1[i] + "     ");

            Console.Write("\n");

            //a1den eleman cıkaralım 

            a1.Remove('A');
            a1.Remove('G');

            Console.WriteLine("A1 in eleman sayısı artık sudur:" + a1.Count);

            foreach (char i in a1)
                Console.Write(i + "    ");
            Console.Write("\n");

            //a1 i büyütelim zorlayalım onu büyürmeye for döngüsü ile

            for (int i = 1; i < 20; i++)
                a1.Add((char)('a' + i));

            Console.WriteLine("a1 in şimdiki kapasitesi " + a1.Capacity);


            Console.WriteLine("\na1 in şimdiki eleman sayısı sudur" + a1.Count);


            Console.WriteLine("\na1 in şimdiki elemanları sunlardır");

            foreach (char i in a1)
                Console.Write(i + " ");
            Console.Write("\n");

            //dizi indekleme kullanrak içeriğini değiştirdik..

            a1[0] = 'X';
            a1[1] = 'Y';
            a1[2] = 'Z';

            Console.WriteLine("\na1 in şimdiki elemanları sunlardır");

            foreach (char i in a1)
                Console.Write(i + " ");
            Console.Write("\n");


            Console.Read();
        }
    }
}
