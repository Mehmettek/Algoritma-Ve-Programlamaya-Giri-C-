
    public class Program
    {
           public static void Main(string[] args)
        {
           Console.Write("İkilk Sistemde Bir sayı Giriniz Örn:(11101)");
           string sayı =Console.ReadLine();
            
           int üs=0;
           double onluksayı=0;
            for (int i = sayı.Length-1; i >= 0; i--)
           {
               onluksayı += (Math.Pow(2, üs) * int.Parse(sayı.Substring(i, 1)));
               üs++;
           
           }
            Console.Write(onluksayı);
             

        }
    }
