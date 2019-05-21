//Klavyeden girilecek 20 sayının tek olanlarını ayrı çift olanlarını ayrı toplayıp
//sonuçları ekrana yazan algoritmayı geliştiriniz



int tt = 0, ct = 0, ca = 0, ta = 0, sayi;

            int sayac=0;
            while(sayac<5)
            {
                sayac = sayac + 1;
                Console.Write("sayi giriniz");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    ct = ct + sayi;
                    ca = ca + 1;
                }
                else

                    tt = tt + sayi;
                ta = ta + 1;


            }
