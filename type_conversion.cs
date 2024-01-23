//1.Otomatik Dönüşüm - Implict Conversion
//küçük veri tipinden daha büyük bir veri tipine atanaması

int sayi = 3;
double sayiDouble = sayi; //otomatik dönüsüm

//2.Acik Dönüsüm - Explicit Conversion
//Büyük veri tipinden küçük veri tipine (özel durumlarda:nesnenin dönüsümü gibi)

double doubleSayi = 5.5;
int intSayi = (int)doubleSayi; //acik dönüsüm

//3.Convert Sinifi Kull. Dönüstürme
//convert sinifi veri tipleri arasında döüsüm saglar.

string strSayi = "123";
int intSayi = Convert.ToInt32(strSayi);

//4.Parse Methodu Kull. Dönüstürme
//bazi durumlarda metni sayiya dönüstürme istenebilir
// int.Parse veya double.Parse kullanabiliriz bu gibi durumlarda.

string strSayi = "123";
int intSayi = int.Parse(strSayi);


