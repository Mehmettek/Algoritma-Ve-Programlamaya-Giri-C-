 double c = 0, kt = 0, ort = 0, sayi, sa;
            Console.Write("kac adet sayi giriceksiniz: ");
            sa = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < sa; i++)
            {

            Console.Write("{0}. sayiyi giriniz", i + 1);
            sayi = Convert.ToDouble(Console.ReadLine());
            kt = kt + sayi;
            c = c + 1;
        }
            ort = kt / sa;

            Console.Write("{0} kadar sayı girildi.. ortalamaları {1}  kareleri toplamı {2} ", c, ort, kt);
            Console.Read();