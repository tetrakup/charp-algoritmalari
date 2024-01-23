using System;

class Program
{
	static void Main()
	{
		int sayi = 5;
		int faktoriyelSonuc = FaktoriyelHesapla(sayi);
		Console.WriteLine($"{sayi}! = {faktoriyelSonuc}");
	}
	
	static int FaktoriyelHesapla(int n)
	{
		if (n == 0 || n == 1)
			return 1;
		
		return n * FaktoriyelHesapla(n - 1);
	}
}
