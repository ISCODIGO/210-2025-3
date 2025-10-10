// while: evaluacion de condicion (bool) -> repeticion/iteracion
// repetir todos los numeros impares desde el 1 hasta el 10

int pasos = 1;
while (pasos <= 10)
{
    Console.WriteLine(pasos);
    pasos += 2;
}

//while (true)
//{
//    Console.WriteLine(pasos);
//    pasos += 2;

//    // condicion de salida
//    if (pasos > 10)
//    {
//        continue;
//    }
//}

//bool seguir = true;
//while (seguir)
//{
//    Console.WriteLine(pasos);
//    pasos += 2;

//    // condicion de salida
//    if (pasos > 10)
//    {
//        seguir = false;
//    }
//}


// do-while: repeticion -> evaluacion
// crear un menu que permita seleccionar opciones y ejecutar segun la eleccion de una calculadora

//int opcion;
//do
//{
//    Console.Clear();
//    Console.WriteLine("Calculadora");
//    Console.WriteLine("0. Salir");
//    Console.WriteLine("1. Sumar");
//    Console.WriteLine("2. Restar");
//    Console.Write("Elige una opcion... ");
//    int.TryParse(Console.ReadLine(), out opcion);

//    switch (opcion)
//    {
//        case 0:
//            break;
//        case 1:
//            Console.Clear();
//            Console.WriteLine("Vamos a sumar");
//            Console.ReadKey();
//            break;
//        case 2:
//            Console.Clear();
//            Console.WriteLine("Vamos a restar");
//            Console.ReadKey();
//            break;
//        default:
//            Console.Clear();
//            Console.WriteLine("Opcion invalida");
//            Console.ReadKey();
//            break;
//    }
//} while (opcion != 0);


//for (int i = 1; i <= 10; i+=2)
//{
//    Console.WriteLine(i);
//}



// for (inicializacion; condicion(true); actualizacion)
// un programa que detecte numeros primos
// numero primo? tiene al menos un divisor que no sea 1 ni si mismo.

Console.Write("Escriba un numero: ");
int.TryParse(Console.ReadLine(), out int numero);
bool esPrimo = true;

for (int candidato = 2; candidato < numero; candidato++)
{
    if (numero % candidato == 0)
    {
        esPrimo = false;
        break;
    }
}
if (esPrimo)
{
    Console.WriteLine("Es primo");
}
else
{
    Console.WriteLine("Es compuesto");
}

// foreach (array)