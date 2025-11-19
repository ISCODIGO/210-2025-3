using System.Diagnostics;

public class Program
{
    static void Main(string[] args)
    {
        // Crear archivo de prueba más grande
        using (StreamWriter streamWriter = new StreamWriter("data.txt"))
        {
            for (int i = 1; i <= 100000; i++)
            {
            streamWriter.WriteLine($"Línea {i} con contenido adicional para hacer el archivo más grande");
            }
        }

        // Método 0: File.ReadAllText (para comparación)
        Stopwatch sw0 = Stopwatch.StartNew();
        string allText = File.ReadAllText("data.txt");
        sw0.Stop();
        Console.WriteLine($"File.ReadAllText: {sw0.ElapsedMilliseconds} ms");

        // Método 1: Read simple (carácter por carácter)
        Console.WriteLine("=== Comparación de métodos de lectura ===");

        Stopwatch sw1 = Stopwatch.StartNew();
        using (StreamReader reader1 = new StreamReader("data.txt"))
        {
            int character;
            while ((character = reader1.Read()) != -1)
            {
                // Procesar carácter (sin mostrar para no contaminar medición)
            }
        }
        sw1.Stop();
        Console.WriteLine($"Read simple (carácter por carácter): {sw1.ElapsedMilliseconds} ms");

        // Método 2: Read con buffer pequeño
        Stopwatch sw2 = Stopwatch.StartNew();
        using (StreamReader reader2 = new StreamReader("data.txt"))
        {
            char[] buffer = new char[128];
            int bytesRead;
            while ((bytesRead = reader2.Read(buffer)) > 0)
            {
                // Procesar buffer
            }
        }
        sw2.Stop();
        Console.WriteLine($"Read con buffer 128: {sw2.ElapsedMilliseconds} ms");

        // Método 3: Read con buffer grande
        Stopwatch sw3 = Stopwatch.StartNew();
        using (StreamReader reader3 = new StreamReader("data.txt"))
        {
            char[] buffer = new char[8192];
            int bytesRead;
            while ((bytesRead = reader3.Read(buffer)) > 0)
            {
                // Procesar buffer
            }
        }
        sw3.Stop();
        Console.WriteLine($"Read con buffer 8192: {sw3.ElapsedMilliseconds} ms");

        // Método 4: ReadLine
        Stopwatch sw4 = Stopwatch.StartNew();
        using (StreamReader reader4 = new StreamReader("data.txt"))
        {
            string? line;
            while ((line = reader4.ReadLine()) != null)
            {
                // Procesar línea
            }
        }
        sw4.Stop();
        Console.WriteLine($"ReadLine: {sw4.ElapsedMilliseconds} ms");

        // Método 5: ReadToEnd
        Stopwatch sw5 = Stopwatch.StartNew();
        using (StreamReader reader5 = new StreamReader("data.txt"))
        {
            string content = reader5.ReadToEnd();
        }
        sw5.Stop();
        Console.WriteLine($"ReadToEnd: {sw5.ElapsedMilliseconds} ms");

        // Comparación de métodos de escritura
        Console.WriteLine("\n=== Comparación de métodos de escritura ===");
        CompareWriteMethods();
    }

    // Comparación de métodos de escritura
    static void CompareWriteMethods()
    {
        const int numberOfLines = 1_000_000;
        string[] testData = new string[numberOfLines];
        for (int i = 0; i < testData.Length; i++)
        {
            testData[i] = $"Línea de prueba {i} con contenido para escritura";
        }

        // Método 1: File.WriteAllText
        Stopwatch swWrite1 = Stopwatch.StartNew();
        File.WriteAllText("output1.txt", string.Join(Environment.NewLine, testData));
        swWrite1.Stop();
        Console.WriteLine($"File.WriteAllText: {swWrite1.ElapsedMilliseconds} ms");

        // Método 2: StreamWriter
        Stopwatch swWrite2 = Stopwatch.StartNew();
        using (StreamWriter writer = new StreamWriter("output2.txt"))
        {
            foreach (string line in testData)
            {
                writer.WriteLine(line);
            }
        }
        swWrite2.Stop();
        Console.WriteLine($"StreamWriter: {swWrite2.ElapsedMilliseconds} ms");

        // Método 3: StreamWriter con buffer
        Stopwatch swWrite3 = Stopwatch.StartNew();
        using (StreamWriter writer = new StreamWriter("output3.txt", false, System.Text.Encoding.UTF8, 8192))
        {
            foreach (string line in testData)
            {
                writer.WriteLine(line);
            }
        }
        swWrite3.Stop();
        Console.WriteLine($"StreamWriter con buffer: {swWrite3.ElapsedMilliseconds} ms");
    }
}