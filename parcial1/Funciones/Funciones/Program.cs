double s = Math.Sqrt(2);
Console.WriteLine(s);

double t = Math.Round(64.56, 0);
Console.WriteLine(t);

int m = Math.Min(2, Math.Min(3, 5));
Console.WriteLine(m);

Random r = new Random();  // Crear un objeto de tipo Random
for (int i = 0; i < 10; i++)
{
    int aleatorio = r.Next(10);  // Rango [0, 9]
    //Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("El numero " + i + " aleatorio es: " + aleatorio);
    //Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine($"El numero {i} aleatorio es: {aleatorio}");
}


int Sumar(out int a, int b)  // Firma
{
    // Cuerpo
    a = 100;
    int total = a + b;
    //a = 100;
    Console.WriteLine("Valor dentro de la funcion de a: " + a);
    return total;
}

//void Editar(int[] a, int posicion, int nuevo)
//{
//    a[posicion] = nuevo;
//}

Console.Clear();
int x = 10;
int y = 20;
Console.WriteLine(Sumar(x, y));
Console.WriteLine("Valor de x fuera de la funcion: " + x);

//int[] ints = { 1, 2, 3, 4 };
//Editar(ints, 1, 100);
//for (int i = 0; i < ints.Length;i++)
//{
//    Console.Write(ints[i] + ",");
//}
