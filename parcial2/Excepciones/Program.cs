Console.WriteLine("--> Inicia el programa");

//int.TryParse(Console.ReadLine(), out int x);
//int.TryParse(Console.ReadLine(), out int y);

//// Programacion Defensiva: es posible prevenir la excepcion
//// Es complicado estar al tanto de todas las excepciones
//if (y != 0) {
//    Console.WriteLine(x/y);
//}

// Manejar excepciones: la excepcion ocurre pero es controlada
try {
    // try: colocamos las sentencias que pueden provocar una excepcion
    int numero = int.Parse(Console.ReadLine());
    Console.WriteLine(10/numero);
    int[] arreglo = {1, 2, 3, 4};
    arreglo[100] = 10;
} 
//catch(DivideByZeroException d) 
//{
//    // catch: se utiliza este bloque cuando ha ocurrido una excepcion
//    Console.WriteLine(d);
//}
//catch(SystemException se) 
//{
//    Console.WriteLine("SystemException: " + se);
//}
catch (Exception e)
{
    Console.WriteLine($"*** Error general: {e}");
}
finally
{
    // Se ejecuta ocurra o no la excepcion
    Console.WriteLine("-------------> Finally");
}

Console.WriteLine("--> Fin del programa");