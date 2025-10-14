// declaracion
int[] numeros = new int[5];
// una coleccion de 5 enteros [0, 0, 0, 0, 0]
// los indices son del [0, 4]

// modificacion de los elementos del arreglo
numeros[0] = 10;
numeros[1] = 20;
numeros[2] = 30;
numeros[3] = 40;
numeros[4] = 50;

/* 
Valores predeterminados:
    enteros [byte, short, char, int, long, ...] = 0
    flotantes = 0.0
    bool = false
    string = ""
    cualquier otro object = null
 */ 

for (int i = 0; i < numeros.Length; i++)
{   
    if (i % 2 == 0)
    {
        numeros[i] *= -1;
    }
}

// imprimir el contenido del arreglo
// foreach (tipo variable-que-recorre-la-coleccion in coleccion)
// como la variable se define por cada iteracion no se modifica el arreglo
foreach (var numero in numeros)
{
    Console.Write(numero);
    Console.Write(", ");
}

Console.WriteLine("\nEl ultimo elemento es: " + numeros[4]);

// declaracion e inicializacion
string[] paises = { "Honduras", "El Salvador", "Costa Rica", "Nicaragua" };
Console.WriteLine($"Se ha registrado {paises.Length} paises");