 string mevsim;
            Console.Write("mevsim giriniz");
            mevsim = Console.ReadLine();
            switch (mevsim)
            {
                case "kış": Console.Write("aralık  ocak  subat");
                    break;
                case "yaz": Console.Write("haziran temmuz agustos");
                    break;
                case "sonbahar": Console.Write("eylül ekim kasım");
                    break;
                case "ilkbahar": Console.Write("mart nisan mayıs");
                    break;
                default: Console.Write("yanlıs mevsim adı");
                    break;
            }
            Console.Read();
