//Dikdötgen,  alan ve cevresini bulma


 int kk, uk, a = 0, c = 0;
            for (int i = 1; i <= 4; i++)
            {
                Console.Write("uzun kenar:");
                uk = Convert.ToInt32(Console.ReadLine());
                Console.Write("kısa kenar:");
                kk = Convert.ToInt32(Console.ReadLine());

                a = kk * uk;
                c = (2 * kk) + (2 * uk);
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("kısa kenar {0}  uzun kenar {1}   ALAN={2}   CEVRE={3}  ", kk, uk, a, c);

                Console.WriteLine
                    ("------------------------------------------------------------------------");
            }
            Console.ReadKey();
