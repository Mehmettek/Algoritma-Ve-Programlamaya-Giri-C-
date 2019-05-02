int sonuc, sayi, yuz;
            Console.Write("A sayısı:");
            sayi = int.Parse(Console.ReadLine());
            sonuc = sayi % 1000;
            yuz = sonuc / 100;
            Console.Write("{0} sayısının yüzler basamagı = {1} \n", sayi, sonuc);
           
            Console.Read();