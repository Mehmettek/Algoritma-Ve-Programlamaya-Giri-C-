int tpl = 0,sayi;
            int[] a={0,1,2,3,4,5,6,7,8,9};
            for (int i = 0; i < a.Length - 1; i++)
            {
                 switch (i)
                {
                    case 2: tpl = tpl + a[i];
                        break;
                    case 6:tpl=tpl+a[i];
                        break;
                      
                }

            }
            Console.Write(tpl);
            Console.Read();