using System;
					
public class Program
{
	public static void Main()
	{
		int dyil=0,byil=0;
		
		Console.Write("Bulunduğunuz Yılı Giriniz");
		byil=int.Parse(Console.ReadLine());
		Console.Write("Doğum tarihinizi Giriniz");
		dyil=int.Parse(Console.ReadLine());
		Console.WriteLine("Yasınız {0}",byil-dyil);
	}
}
