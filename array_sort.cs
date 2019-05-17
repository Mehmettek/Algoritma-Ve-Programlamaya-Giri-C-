  public class Program
    {
        public static void Main(string[] args)
        { 
            int[] dizi={4,5,67,99,4,0,-1,3};
            Array.Sort(dizi);
            Console.WriteLine("Küçükten Büyüğe Sıraladık");
            foreach(int i in dizi){
                Console.Write(i+ " "); 
            }
             Console.Write("\n");
              Array.Reverse(dizi);
            Console.WriteLine("Büyükten Küçüğe Sıraladık");
            foreach(int i in dizi){
                Console.Write(i+" "); 
            }
             Console.Write("\n");
  
        }
    }
