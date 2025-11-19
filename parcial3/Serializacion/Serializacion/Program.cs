using Serializacion;
using System.Text.Json;

Libreria libreria = new Libreria("Navarro", 10);

libreria.AgregarLibro(new Libro("El Quijote de la Mancha", "Cervantes", "209443253", 2024));
libreria.AgregarLibro(new Libro("El Aleph", "Borges", "204656456", 2020));

libreria.ImprimirLibros();

// Serializar: convertir un objeto a un archivo JSON
Console.WriteLine("Serializar datos...");
string json = JsonSerializer.Serialize(libreria);

using (StreamWriter writer = new StreamWriter("datos.json"))
{
   writer.Write(json);
}

// Deserializar: convertir el archivo json2 en un objeto
Console.WriteLine("Deserializar datos...");
string json2 = File.ReadAllText("datos.json");
var lib = JsonSerializer.Deserialize<Libreria>(json2);

lib?.ImprimirLibros();