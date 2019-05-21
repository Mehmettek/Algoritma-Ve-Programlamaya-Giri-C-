 int[] sayi ={ 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 ,-4,-7,-8,-9,0};
            int toplam = 0,ct=0,tk=0;

            for (int i = 0; i < sayi.Length; i++)
            {
                if (sayi[i] % 2 == 0 && sayi[i] >= 0)
                {
                    Console.WriteLine(" sayi " + sayi[i]);
                    ct = ct + sayi[i];
                }
                else
                {
                    tk = tk + sayi[i];
                }
                
            }
            Console.WriteLine(" cift toplamlar" + ct + "tek toplamlar" + tk );
            Console.ReadKey();
