//dizideki sayı 100 ve 200 arasında değil ise &10 artırma




double[] a = new double[5];
            for ( int i = 0; i <= a.Length - 1; i++)
            { Console.Write(i + ". sayıyı giriniz ");
            a[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (a[i] < 100 || a[i] > 200)
                {
                    a[i] = a[i] * 1.10;  //%10 artırılıyor
                    Console.WriteLine(a[i]);
                }
            }
            Console.Read();
