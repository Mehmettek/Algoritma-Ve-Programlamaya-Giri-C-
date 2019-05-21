girilen sayilarin yerlerini değiştirme
 int tmp=0,a,b;

            Console.Write("harf giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("harf giriniz");
           b = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("sayilerin ilk hali a={0}   b={1}", a, b);
           tmp = a;
           a = b;
           b = tmp;

           Console.Write(" sayilarin yer dgiştirilmis hali    a={0}  b={1}", a, b);
           Console.Read();
