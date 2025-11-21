using Serializacion;
using System.Text.Json;

Console.WriteLine("=== MENÚ ===");
Console.WriteLine("1. Serializar datos");
Console.WriteLine("2. Deserializar datos");
Console.Write("Seleccione una opción (1-2): ");

string? opcion = Console.ReadLine();

switch (opcion)
{
   case "1":
      // Serializar: convertir un objeto a un archivo JSON
      Libreria libreria = new Libreria("Navarro", 10);

      libreria.AgregarLibro(new Libro("El Quijote de la Mancha", "Cervantes", "209443253", 2024));
      libreria.AgregarLibro(new Libro("El Aleph", "Borges", "204656456", 2020));
      libreria.AgregarLibro(new Libro("Cien Años de Soledad", "Gabriel Garcia Marquez", "203453453", 2019));

      Console.WriteLine("Serializando datos...");
      string json = JsonSerializer.Serialize(libreria, new JsonSerializerOptions
      {
          WriteIndented = true,
      });
      using (StreamWriter writer = new StreamWriter("datos.json"))
      {
         writer.Write(json);
      }
      Console.WriteLine("Datos serializados correctamente.");
      break;

   case "2":
      // Deserializar: convertir el archivo json en un objeto
      Console.WriteLine("Deserializando datos...");
      if (File.Exists("datos.json"))
      {
         string json2 = File.ReadAllText("datos.json");
         var lib = JsonSerializer.Deserialize<Libreria>(json2);
         lib?.ImprimirLibros();
      }
      else
      {
         Console.WriteLine("El archivo datos.json no existe.");
      }
      break;

   default:
      Console.WriteLine("Opción no válida.");
      break;
}