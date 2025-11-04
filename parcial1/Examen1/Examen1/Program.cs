// Ejercicio 1
int Cuenta(int[] numeros) {
    int total = 0;
    foreach (int numero in numeros)
    {
        if (numero % 2 == 0)
        {
            total++;
        }
    }
    return total;
}

var resultado = Cuenta(new int[] { 3, 4, 6, 7, 2 });
Console.WriteLine(resultado);

// Ejercicio 2
int.TryParse(Console.ReadLine(), out int N);
int suma = 0;
for(int i = 1; i <= N; i+=2)
{
    suma += i;
}
Console.WriteLine($"La suma de 1 al {N} es {suma}");