 Random rastgele = new Random();
             double enb = 0,ort=0,bn=0,g=0,k=0;
             double s1, s2, s3;
            for (int i = 1; i <= 60; i++)
            {
                s1 = rastgele.Next(1,101);
                s2 = rastgele.Next(1,101);
                s3 = rastgele.Next(1,101);
                if (s1 > s2 && s1 > s3)
                {
                    enb = s1;
                }
                else if (s2 > s1 && s2 > s3)
                {
                    enb = s2;

                }
                else
                {
                    enb = s3;
                }
               

                //1-2-3  and 3-2-1 
                if ((s2 > s1 && s2 < s3) || (s2 < s1 && s2 > s3))
                {
                    ort = s2;
                }
                //2-1-3 and 2-3-1
                else if ((s1 > s2 && s1 < s3) || (s1 < s2 && s1 > s3))
                {
                    ort = s1;
                }
                else { ort = s3; }


                bn = (enb * 0.60) + (ort * 0.40);
                if (bn >= 60)
                {

                    g++;
                }
                else
                {
                    k++;
                }


            }
            Console.Write("gecenler: {0}\n kalanlar : {1}", g, k);
            Console.Read();