public class Program
    {
        public static void Main(string[] args)
        { 
            int result=1;
            int number=4; //you can change this value or request from the user
            for(int i=1;i<=number;i++){
            result*=i;
              }
            
            Console.WriteLine("{0}  Factorial: {1}",number,result);
            
  
        }
    }
