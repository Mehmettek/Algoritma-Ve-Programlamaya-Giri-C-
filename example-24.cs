 class Program
    {
        static void Main(string[] args)
        {
            int urunno;
            double sm,fiyat=0,toplam=0;
            Console.Write("Bir Ürün Numarası Giriniz :(Çıkış İçin -1'e Basınız):  ");
            urunno = Convert.ToInt16(Console.ReadLine());

            while (urunno != -1)
            {
                Console.Write("Satış Miktarı Giriniz : ");
                sm = Convert.ToInt16(Console.ReadLine());

                switch (urunno)
                {
                    case 1:
                        fiyat = 2.50 * sm;
                        Console.Write("Bu ürünün Fiyatı {0} : ",fiyat);  
                        break;
                    case 2:
                        fiyat = 3.16 * sm;
                        Console.Write("Bu ürünün Fiyatı {0} : ", fiyat);
                        break;
                    case 3:
                        fiyat = 4.60 * sm;
                        Console.Write("Bu ürünün Fiyatı {0} : ", fiyat);
                        break;
                    case 4:
                        fiyat = 5.12 * sm;
                        Console.Write("Bu ürünün Fiyatı {0} : ", fiyat);
                        break;
                    case 5:
                        fiyat = 6.20 * sm;
                        Console.Write("Bu ürünün Fiyatı {0} : ", fiyat);
                        break;
                    default:
                        Console.WriteLine("Lütfen Geçerli Ürün Giriniz");
                        break;
                }
                toplam += fiyat;
                Console.Write("\nBir Ürün Numarası Giriniz :(Çıkış İçin -1'e Basınız):  ");
                urunno = Convert.ToInt16(Console.ReadLine());
               
            }
            Console.Write("Toplam Fiyat : " + toplam);
            Console.ReadKey();
        }
    }
