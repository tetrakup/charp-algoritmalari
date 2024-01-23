using System;

class Program
{
	static void hi()//basit method tanimi
	{
		System.Console.WriteLine("hi guys");
	}	

	static void hiTo(string name)//parametre elen metod tanim
	{
		System.Console.WriteLine($"hi,{name}!");
	}

	static int Add(int num1,int num2)//2parametre alan ve deger donduren method tanimi
	{
		return num1 + num2;
	}

	static void Main()
	{
		hi();
		hiTo("Cey");
		int Add2 = Add(5,3);
		System.Console.WriteLine($"Answer: {Add2}");
	}
}
