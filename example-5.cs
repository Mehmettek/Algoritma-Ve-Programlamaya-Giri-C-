  int gecici;
            int[] sayilar = new int[5] { 3, 9, 12, 1, 7 };
            Console.Write("Dizinin ilk hali: ");
            foreach (int deger in sayilar)
            {
                Console.Write(deger + " ");
            }

            for (int i = 0; i < sayilar.Length; i++)
            {
                for (int j = i + 1; j < sayilar.Length; j++)
                {
                    if (sayilar[j] < sayilar[i])
                    {
                        gecici = sayilar[i];
                        sayilar[i] = sayilar[j];
                        sayilar[j] = gecici;
                    }
                }
            }
            foreach (int c in sayilar)
            {

                Console.WriteLine("{0}", c);

            } 
                Console.Read();
