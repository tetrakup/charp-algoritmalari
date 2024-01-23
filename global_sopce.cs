class Program
{
	static int globalDegisken = 10;//global kapsaminda tanimlanan degisken

	static void Main()
	{
		System.Console.WriteLine(globalDegisken); //erisilebilir
		LocalKapsam();
	}

	static void LocalKapsam()
	{
		System.Console.WriteLine(globalDegisken);// erisilebilir
	}
}
//global space :
//bir degiskenin global kapsamında tanımlanması, o degiskenin prog. herhangi bir yerinde olmasını saglar
//global degiskenler genellikle prog. basinda tanimlanir ve programin sonuna kadar yasar.
