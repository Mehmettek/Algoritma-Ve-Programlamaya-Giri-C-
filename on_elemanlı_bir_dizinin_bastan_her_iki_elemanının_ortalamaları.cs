int[] x = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            int[] ort = new int[5];
            int a = 0, tpl = 0; ;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    tpl += x[a];
                    a++;
                }
                ort[i] = tpl / 2;
                tpl = 0;
            }
            Console.WriteLine("************Sayıların Ortalaması****************");
            foreach (int i in ort)
            {
                Console.Write("    " + i + "      ");
            }
            Console.Read();