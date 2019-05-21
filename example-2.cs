//Klavyeden girilen A ve B gibi iki sayıyı, çarpma işlemi kullanmadan sadece
//toplama ve çıkarma kullanarak çarpıp sonucu ekrana yazan algoritmayı
//yazınız.


int say = 0, topla = 0, a, b;
            int[] c = new int[2];
            

            for (int i = 0; i < c.Length; i++)
            {


                Console.Write("sayi giriniz");
                c[i] = Convert.ToInt32(Console.ReadLine());
                    if (c[i] == 0)
                {
                    Console.Write(say);
                    Console.Read();   
                }

            }
            for (int j = 0; j < c[0]; j++)
            {
                topla = topla + c[1];
                
                

            }
            Console.Write(topla);


            
            Console.Read();
