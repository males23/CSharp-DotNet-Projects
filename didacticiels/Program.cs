// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Chaque bloc dans une fonction et on appelle celle que nous voulons tester.

//TestBloc1();
TestBloc2();

void TestBloc1()
{
    //Déclarer et utiliser des variables
    string aFriend = "Bill";
    Console.WriteLine(aFriend);
    aFriend = "Maira";
    Console.WriteLine(aFriend);
    Console.WriteLine("Hello " + aFriend);
    Console.WriteLine($"Hello {aFriend}");

    //Utiliser des chaînes avec Lenght
    string firstFriend = "Maria";
    string secondFriend = "Sage";
    Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
    Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
    Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

    //Supprimer l’espace blanc des chaînes avec Trim()
    string greeting = "      Hello World!       ";
    Console.WriteLine($"[{greeting}]");

    string trimmedGreeting = greeting.TrimStart();
    Console.WriteLine($"[{trimmedGreeting}]");

    trimmedGreeting = greeting.TrimEnd();
    Console.WriteLine($"[{trimmedGreeting}]");

    trimmedGreeting = greeting.Trim();
    Console.WriteLine($"[{trimmedGreeting}]");
    Console.WriteLine("Bloc 1 exécuté");

    //Rechercher et remplacer du texte dans des chaînes
    string sayHello = "Hello World!";
    Console.WriteLine(sayHello);
    sayHello = sayHello.Replace("Hello", "Greetings");
    Console.WriteLine(sayHello);
    Console.WriteLine("Bloc 2 exécuté");

    //Majuscules ou en minuscules
    Console.WriteLine(sayHello.ToUpper());
    Console.WriteLine(sayHello.ToLower());

    //recherche et de remplacement avec Contains (True ou False)
    string songLyrics = "You say goodbye, and I say hello";
    Console.WriteLine(songLyrics.Contains("goodbye"));
    Console.WriteLine(songLyrics.Contains("greetings"));

    //Explorer les mathématiques entières
    int a = 18;
    int b = 6;
    int d = 2;
    int c = a + b;
    Console.WriteLine(c);


    // subtraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);


    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);

    //Explorer la précision et les limites des entiers
    int i = (a + b) / c;
    int j = (a + b) % c;
    Console.WriteLine($"quotient: {i}");
    Console.WriteLine($"remainder: {j}");

    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}");

    int what = max + 3;
    Console.WriteLine($"An example of overflow: {what}");

    //Utiliser le type double
    double z = 19;
    double x = 23;
    double w = 8;
    double u = (z + x) / w;
    Console.WriteLine(u);

    double max1 = double.MaxValue;
    double min1 = double.MinValue;
    Console.WriteLine($"The range of double is {min1} to {max1}");

    //les doubles en C# peuvent avoir des erreurs d’arrondi
    double third = 1.0 / 3.0;
    Console.WriteLine(third);

    //le type décimal a plus de chiffres à droite du point décimal.
    decimal min2 = decimal.MinValue;
    decimal max2 = decimal.MaxValue;
    Console.WriteLine($"The range of the decimal type is {min2} to {max2}");

    double n = 1.0;
    double m = 3.0;
    Console.WriteLine(n / m);

    decimal l = 1.0M;
    decimal r = 3.0M;
    Console.WriteLine(l / r);
    
    //Les Tuples (plusieurs valeurs dans unee seule variable)
    var pt = (X: 1, Y: 2);
    var slope = (double)pt.Y / (double)pt.X;
    Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");

    pt.X = pt.X + 5;
    Console.WriteLine($"The point is now at {pt}.");

    var pt2 = pt with { Y = 10 };
    Console.WriteLine($"The point 'pt2' is at {pt2}.");

    var subscript = (A: 0, B: 0);
    subscript = pt;
    Console.WriteLine(subscript);

    var namedData = (Name: "Morning observation", Temp: 17, Wind: 4);
    var person = (FirstName: "", LastName: "");
    var order = (Product: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m);
    Console.WriteLine($"enfin {namedData} + {person}  + {order}");

}

void TestBloc2()
{
    // Créer des types d’enregistrements
    Point pt3 = new Point(1, 1);
    var pt4 = pt3 with { Y = 10 };

    Console.WriteLine($"The two points are {pt3} and {pt4}");
}

// Déclaration du record (doit être en dehors de la méthode)
public record Point(int X, int Y);


