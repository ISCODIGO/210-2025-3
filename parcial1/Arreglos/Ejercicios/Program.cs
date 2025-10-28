/*
6-4
Write a program that prints all possible cards from a standard deck of cards, 
without jokers (there are 52 cards: 4 suits of 13 cards).

Figuras:
corazon = 0
diamantes = 1
treboles = 2
picas = 3

Cartas:
As, 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K
1                               11 12 13
*/

//for (int i = 0; i < 4; i++)
//{
//    for (int j = 1; j <= 13; j++)
//    {
//        string figura = i switch
//        {
//            0 => "corazones",
//            1 => "diamantes",
//            2 => "treboles",
//            3 => "picas",
//        };

//        string valor = j switch
//        {
//            1 => "AS",
//            11 => "J",
//            12 => "Q",
//            13 => "K",
//            _ => j.ToString(),
//        };

//        Console.WriteLine($"{valor} de {figura}");
//    }
//}


/*
6-5
Write a program that reads from the console number N and print the sum 
of the first N members of the Fibonacci sequence: 
0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377,
0  1  2  3  4  5  6  7   8   9   10  11  12   13   14
*/

//Console.Write("Escriba un numero: ");
//int.TryParse(Console.ReadLine(), out int N);

//// obtener la secuencia de fibonacci;
//int anterior = 0;
//int ultima = 1;
//int pasos = 2;
//int suma = 1;

//if (N <= 0)
//{
//    suma = 0;
//}

//while (pasos <= N)
//{
//    int temp = ultima;
//    ultima = ultima + anterior;
//    anterior = temp;
//    suma += ultima;
//    // Console.WriteLine(anterior + ", " + ultima);
//    pasos++;
//}
//Console.WriteLine($"Los primeros {N} fibonacci suman {suma}");

Console.WriteLine("Triangulos");

for (int i = 0; i < 4; i++)
{
    // M * (1 esp) + N * (figura + 1 esp)
    // M = 3-i
    // N = i+1

    int inicio = 3 - i;
    int figuras = i + 1;

    // Espacios iniciales
    for (int j = 1; j <= inicio; j++)
    {
        Console.Write(" ");
    }

    // figuras
    for (int k = 1; k <= figuras; k++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}