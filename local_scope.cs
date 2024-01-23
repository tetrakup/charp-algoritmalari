class Program
{
	static void Main()
	{
		int localDegisken = 5;//main icinde yerel degisken

		if(true)
		{
			int innerDegisken = 7;//if bog. icindeki yerel degisken
			System.Console.WriteLine(localDegisken);//erisilebilir
			System.Console.WriteLine(innerDegisken);//erisilebiir
		}

	//System.Console.WriteLine(innerDegisken);//innerDegisken burada tanimli olmd. icin hata verir
	}
}
//Local Scope (Yerel Kapsam):
//Bir degisken tanimlandigi blok icinde gecerlidir
//Yerel degiskenler tanimlandiklari bloktan cikinca ömrünü tamamlar.
