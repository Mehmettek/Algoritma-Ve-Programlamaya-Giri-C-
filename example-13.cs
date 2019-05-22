 int a, b, c;
            Console.Write("dereceyi giriniz");
            a = Convert.ToInt16(Console.ReadLine());
            if (a < 0)
            {
                Console.Write("kati");
            }
            else if (a >= 0 && a <= 100)
            {
                Console.Write("sivi");

            }
            else
            {
                Console.Write("gaz");
            }
            Console.ReadKey();
