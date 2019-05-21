Klavyeden girilecek N adet sayıdan en büyüğünün  en kücük ve sıralarına buldurma bulunması…



int n,i=0, sayi, enb = 0, enk = 27500, eb = 0, ek = 0;
            Console.Write("N degerini giriniz");
            n = Convert.ToInt32(Console.ReadLine());
            while (i < n)
            {
                Console.Write("sayiyi gitriniz");
                sayi = Convert.ToInt32(Console.ReadLine());
                i = i + 1;
                if (sayi > enb)
                {
                    enb = sayi;
                    eb = i;
               }
               if (sayi < enk)
                {
                    enk = sayi;
                    ek = i;

                }
 
            }
            Console.WriteLine("{0} TANE SAYİ İCİNDE---------",n);
            Console.WriteLine(" EN BÜYÜK {0} VE SIRASI {1}",enb,eb);
            Console.WriteLine(" EN KÜCÜK {0} VE SIRASI {1}",enk,ek);
            Console.Read();
