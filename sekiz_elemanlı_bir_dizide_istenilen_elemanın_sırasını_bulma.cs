  string s = "Yok";
            string[] y = { "ali", "veli", "can", "emin", "nihat", "iclal", "mert", "cem" };
          
            String deger = "";
           
                Console.Write("Bulmak İstediğiniz İsmi Giriniz: ");

                deger =Console.ReadLine();
                for (int i = 0; i < y.Length; i++)
                {
                    if (y[i] == deger)
                    {
                        s = (i+1) + ". sırada";
                        break;
                    }
            
            }
 
            Console.Write(s);
            Console.Read();