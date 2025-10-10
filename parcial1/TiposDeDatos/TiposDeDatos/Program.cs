bool booleano = false;

// Enteros
int x = 0;  // con signo (signed) 32 bits [2^31, 2^31 - 1]
byte y = 0; // sin signo (unsigned) 8 bits [0, 255]
y = 255;
++y;
//y++;
Console.WriteLine(y);  // 257??

// Otros enteros
long largo = 1234567890123456789L; // 64 bits
short corto = -32768;              // 16 bits
uint sinSigno = 4294967295U;       // unsigned int, 32 bits
sbyte peque = -128;                // signed byte, 8 bits
ulong muyLargo = 18446744073709551615UL; // unsigned long, 64 bits

// Caracteres
char letra = 'a';  // 16 bits sin signo
Console.WriteLine((int)char.MinValue);
letra = (char)125;  // una conversion explicita => A a = (A) b
Console.WriteLine(letra);

// Flotantes: float (32 bits), double (64 bits), decimal
float flotante = 3.14f;
double doble = 3.141592653589793;
decimal dec = 3.1415926535897932384626433832m;

Console.WriteLine(0.1 + 0.2);
Console.WriteLine(flotante);
Console.WriteLine(doble);
Console.WriteLine(dec);

// Otros tipos de datos
string texto = "Hola, mundo"; // Cadena de texto
Console.WriteLine(texto);

object cualquier = 42; // Puede almacenar cualquier tipo
Console.WriteLine(cualquier);

var inferido = true; // El tipo se infiere automáticamente
Console.WriteLine(inferido);

// tipos Nullable
int? posibleNulo = null;
Console.WriteLine(posibleNulo.HasValue);

// Arrays
int[] arreglo = { 1, 2, 3, 4 };
Console.WriteLine(arreglo[0]);

// Tuple
var tupla = (Id: 1, Nombre: "Ejemplo");
Console.WriteLine(tupla.Nombre);

// Enum
enum Dias { Lunes, Martes, Miercoles }
Dias dia = Dias.Lunes;
Console.WriteLine(dia);
