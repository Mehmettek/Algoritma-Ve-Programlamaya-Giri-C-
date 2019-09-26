using System;
					
public class Program
{
	public static void Main()
	{
	Console.Write("Birinci kenarı Giriniz: ");
     int k1 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("İkinci kenarı Giriniz:");
    int k2 = Convert.ToInt32(Console.ReadLine());
    
	int hip  = (int)Math.Sqrt((k1*k1)+(k2*k2));
    Console.WriteLine("Hipotenüsün Uzunluğu: {0}", hip); 
	}
}
