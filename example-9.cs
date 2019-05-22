
            int sayi;
            Console.Write("1 ile 7 arasında bir deger giriniz");
            sayi = Convert.ToInt16(Console.ReadLine());
            switch (sayi) {
                case 1: Console.Write("gün pazartesi");
                    break;
                case 2: Console.Write("gün salı");
                    break;
                case 3: Console.Write("gün carsamba");
                    break;
                case 4: Console.Write("gün persembe");
                    break;
                case 5: Console.Write("gün cuma");
                    break;
                case 6: Console.Write("gün cumartesi");
                    break;
                case 7: Console.Write("gün pazar");
                    break;
                default: Console.Write("hatalı gün girisi");
                    break;
            }
            Console.Read();
