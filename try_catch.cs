using System;
class Program
{
	static void Main()
	{
		System.Console.Write("Bir Sayi Girin:");
		string userInput=Console.ReadLine();

		try
		{
			int intSayi = Convert.ToInt32(userInput);
			Console.WriteLine("Dönüşüm başarılı. Sayi:" + intSayi);
		}
		catch(FormatException)
		{
			Console.WriteLine("Hata, geçerli bir sayi giriniz.");
		}
		catch(OverflowException)
		{
			System.Console.WriteLine("Girdiğiniz sayi çok büyük/küçük");
		}
	}
}
