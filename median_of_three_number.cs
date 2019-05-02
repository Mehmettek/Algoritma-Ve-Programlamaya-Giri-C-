string a1="a", b1="b", c1="c";
            int enb=0, a, b, c;

            Console.Write("{0} enter", a1);
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("{0} enter", b1);
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("{0} enter", c1);
            c = Convert.ToInt16(Console.ReadLine());

            if ((a > b) && (a < c) || (a > c) && (a < b))
            {
                enb = a;
            }
            else if ((b > a) && (b < c) || (b > c) && (b < a))
            { enb = b; }
            else 
            { enb = c; }
            Console.Write(enb);
            Console.Read();