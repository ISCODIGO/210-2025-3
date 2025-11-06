using System.Text;

string cadena = "Hola mundo";

cadena = cadena.ToUpper();

Console.WriteLine("CompareTo: " + cadena.CompareTo("zapato"));

Console.WriteLine("Minuscula: " + cadena.ToLower());

Console.WriteLine("Mayuscula: " + cadena.ToUpper());

string demo = "1234567890abcdefghijklmnopqrstuvwxyz";

StringBuilder builder = new StringBuilder();

for (int i = 0; i < 10000; i++)
{
    //demo += demo;

    builder.Append(demo);
}
Console.WriteLine(builder.Length);


Console.WriteLine("Contains: " + cadena.Contains("mundo"));