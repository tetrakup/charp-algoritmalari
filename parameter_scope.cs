class Program
{
	static void Main()
	{
		int pkSonucu = MetotParametre(3,4);
		System.Console.WriteLine(pkSonucu);//erisilebilir
	}

	static int MetotParametre(int x, int y)
	{
		int toplam =x + y; //metot içerisinde tanimlanan bir yerel degisken
		return toplam;
	}
}
//pk=Parametre Kapsam
//bir metotun icinde tanimlanan parametreler, yalnizca o metot icinde gecerlidir.
