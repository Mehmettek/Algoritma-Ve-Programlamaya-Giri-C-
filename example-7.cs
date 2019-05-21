   int[] sayi ={ 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 ,-4,-7,-8,-9,0};
            int toplam = 0,ct=0,tk=0;

            for (int i = 0; i < sayi.Length; i++)
            {
                if (sayi[i]>0)
                {
                    Console.WriteLine(" sayi >>>>" +sayi[i] + ">>>pozitiftir" );
                   
                }
                else if (sayi[i] == 0)
                {
                    Console.WriteLine("sayi>>>" + sayi[i] + "isaretsizdir");
                }
                else
                {
                    Console.WriteLine("sayi>>>" + sayi[i] + "negatiftir");
                }
            }
            
            Console.ReadKey();
