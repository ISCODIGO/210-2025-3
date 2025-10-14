Console.WriteLine("Matriz (array de 2 dimensiones)");

int[,] matrix = new int[2, 3];  // 2 filas y 3 columnas

/*
0 0 0
0 0 0
*/

matrix[1, 1] = 10;

Console.WriteLine("Cantidad de elementos: " + matrix.Length);
Console.WriteLine("Dim 0: " + matrix.GetLength(0));
Console.WriteLine("Dim 1: " + matrix.GetLength(1));

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0;  j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j]);
        Console.Write(", ");
    }
    Console.WriteLine();
}

Console.WriteLine("Arreglo de 3 dimensiones");
int[,,] cubo = new int[3, 3, 3];
cubo[1, 1, 1] = 5;
Console.WriteLine("Cantidad de elementos: " + cubo.Length);

Console.WriteLine("Dim 0: " + cubo.GetLength(0));
Console.WriteLine("Dim 1: " + cubo.GetLength(1));
Console.WriteLine("Dim 2: " + cubo.GetLength(2));
for (int i = 0; i < cubo.GetLength(0); i++)
{
    for (int j = 0; j < cubo.GetLength(1); j++)
    {
        for (int k = 0; k < cubo.GetLength(2); k++)
        {
            Console.Write(cubo[i, j, k]);
            Console.Write(", ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Arreglos irregulares");
int[][] irregulares = new int[3][];
irregulares[0] = new int[]{1, 2};
irregulares[1] = new int[]{3, 4, 5};
irregulares[2] = new int[]{6};

for  (int i = 0; i < irregulares.Length; i++)
{
    for (int j = 0; j < irregulares[i].Length; j++)
    {
        Console.Write(irregulares[i][j]);
        Console.Write(", ");
    }
    Console.WriteLine();
}