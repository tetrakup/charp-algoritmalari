using System;

class Person
{
	public Person()//default constructor(parametresiz)
	{
		System.Console.WriteLine("Parametresiz constructor cagirildi.");
		Name = "bilgi yok";
		Age = 0;
	}

	public Person(string name, int age)//parametre alan constructor
	{
		System.Console.WriteLine("Parametreli constructor cagirildi");
		Name = name;
		Age = age;
	}

	//properties
	public string Name { get; set;}
	public int Age { get; set;}

	//sinif degiskenleri
	public static Person person1;
	public static Person person2;
}

class Program
{
	static void Main()
	{
		//parametresiz constructor cagiriliyor.
		Person.person1 = new Person();
		System.Console.WriteLine($"Ad: {Person.person1.Name}, Yaş: {Person.person1.Age}");
	
		//parametreli constructor cagiriliyor
		Person.person2 = new Person("Cey",24);
		System.Console.WriteLine($"Ad: {Person.person2.Name}, Yaş: {Person.person2.Age}");
	}
}
