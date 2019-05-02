 while (true)
            {
                double kvt = 1, k;
                Console.Write("kuvvet giriniz");
                k = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < k; i++)
                {
                    kvt = kvt * 2;
                }
                Console.WriteLine(kvt);
            }
            Console.Read();