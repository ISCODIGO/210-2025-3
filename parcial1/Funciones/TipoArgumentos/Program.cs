// in, out, ref

// ref permite enviar un argumento por referencia.
// argumento por valor (se envia una copia).
// ref: necesita que la variable haya sido declarada e inicializada
// antes de utilizarla.
void intercambio(ref int a, int b)
{
    int temp = a;
    a = b;
    b = temp;
}

int x = 10;
int y = 20;

intercambio(ref x, y);
Console.WriteLine($"Primer variable: {x} y 2da variable: {y}");



int Division(int divisor, int dividendo, out int residuo)
{
    int cociente = divisor / dividendo;
    residuo = divisor % dividendo;
    return cociente;
}

int n1 = 5;
int n2 = 2;
int resultado = Division(n1, n2, out int n3);
Console.WriteLine($"{n1}/{n2} = {resultado} y con residuo {n3}");

decimal ObtenerISV(decimal precio, bool esGravado, in decimal impuesto)
{
    // impuesto = 2;  // no es posible modificar una variable in
    decimal total = 0;
    if (esGravado)
    {
        total = precio * (1 + impuesto / 100);
    } else
    {
        total = precio;
    }
    return Math.Round(total, 2);
}

decimal telefono = 10999.99m;
var total = ObtenerISV(telefono, true, 15);
Console.WriteLine($"El valor con impuesto de L{telefono} es L{total}");

void Editar(in int[] a, int posicion, int nuevo)
{
    // a = new int[nuevo];
    a[posicion] = nuevo;
}

int[] arreglo = { 10, 20, 30 };
Editar(arreglo, 0, 999);

foreach(int elemento in arreglo)
{
    Console.WriteLine(elemento);
}

// Argumentos opcionales
void Saludar(string persona, string mensaje="Hola")
{
    Console.WriteLine($"{mensaje}, {persona}");
}

Saludar("Jose", "Buenos dias");
Saludar("Maria");

int Sumar(params int[] args)
{
    int total = 0;
    foreach(int i in args)
    {
        total += i;
    }
    return total;
}

Console.WriteLine(Sumar());
Console.WriteLine(Sumar(1, 2));
Console.WriteLine(Sumar(1, 2, 3));
Console.WriteLine(Sumar(1, 2, 3, 4));