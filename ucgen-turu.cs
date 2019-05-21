 int k1, k2, k3;
            Console.Write("1. kenarı giriniz");
            k1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. kenarı giriniz");
            k2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. kenarı giriniz");
            k3 = Convert.ToInt32(Console.ReadLine());

            if ((k1 == k2) && (k2 == k3))
            {
                Console.Write("eşkenar ücgendir");
            }
            else if (k1 == k2)
            {
                Console.Write("ikizkenar ücgen");
            }
            else if (k2 == k3)
            {
                Console.Write("ikizkenaar ücgen");
            }
            else if (k1 == k3)
            { Console.Write("ikizkenar ücgen"); }
            else { Console.Write("standart ücgendir"); }

  Console.Read();
