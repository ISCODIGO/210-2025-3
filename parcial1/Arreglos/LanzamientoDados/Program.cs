// Simular un programa que ejecute 1000 lanzamientos de dados e indique
// cual es el resultado al final de la simulacion

int[] lanzamientos = new int[7];  // [0, 6]
Random r = new Random();

for (int i = 1; i <= 1000; i++)
{
    int lanzamiento = r.Next(6) + 1;  // random [0, 5] + 1 = [1, 6]
    lanzamientos[lanzamiento] += 1;
}

string contenido = string.Join(", ", lanzamientos);
Console.WriteLine(contenido);

int valorMax = lanzamientos.Max();
int valorMin = lanzamientos[1];
int caraMax = 0, caraMin = 0;

for (int k = 1; k < lanzamientos.Length; k++)
{
    if (lanzamientos[k] == valorMax)
    {
        caraMax = k;
    }

    if (lanzamientos[k] < valorMin)
    {
        valorMin = lanzamientos[k];
        caraMin = k;
    }
}

Console.WriteLine($"La cara {caraMax} es la mas repetida, mientras que {caraMin} es la menos");