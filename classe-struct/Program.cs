// See https://aka.ms/new-console-template for more information
/*
En C#, les types concrets sont généralement class
 (type de référence) ou struct (type de valeur). 
 Les record peuvent être l’un ou l’autre. 
 Tous sont utilisés dans l’écosystème de .NET SDK.


//1-classe 
// Appel de la fonction
TestClass();

void TestClass()
{
    Person p1 = new Person();
    p1.Name = "Alice";

    Person p2 = p1; // copie de la référence

    p2.Name = "Bob";

    Console.WriteLine(p1.Name);
}

// Déclaration de la classe
class Person
{
    public string Name;
}
*/

//2-Struct
// Appel de la fonction
TestStruct();

void TestStruct()
{
    Point p1;
    p1.X = 10;

    Point p2 = p1; // copie de la valeur

    p2.X = 20;

    Console.WriteLine(p1.X);
}

// Déclaration du struct
struct Point
{
    public int X;
}