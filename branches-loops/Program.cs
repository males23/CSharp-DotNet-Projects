// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
//Utilisez l'instruction if
int a = 5;
int b = 6;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10.");
*/

/* 
//Utiliser if et else ensemble
int a = 5;
int b = 3;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10");
else
    Console.WriteLine("The answer is not greater than 10");
*/

/*
int a = 5;
int b = 3;
int c = 4;
//if ((a + b + c > 10) && (a == b))
if ((a + b + c > 10) || (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}
*/

/*
//Utiliser des boucles pour répéter des opérations : while et do...while 
int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
}
*/

/*
int counter = 0;
do
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
} while (counter < 10);
*/

/*
//Utiliser la boucle for
for (int counter = 0; counter < 10; counter++)
{
    Console.WriteLine($"Hello World! The counter is {counter}");
}

for (int row = 1; row < 11; row++)
{
    Console.WriteLine($"The row is {row}");
}

for (char column = 'a'; column < 'k'; column++)
{
    Console.WriteLine($"The column is {column}");
}
*/

/*
//Boucles imbriquées
for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}
*/

//Calculer la somme des nombres de 1 à 20 qui sont divisibles par 3
int somme = 0;

for (int i = 1; i <= 20; i++)
{
    if (i % 3 == 0)
    {
        somme += i;
    }
}

Console.WriteLine("La somme est : " + somme);
