# Excepciones en C#

## Definición

Las excepciones en C# son eventos que ocurren durante la ejecución de un programa que interrumpen el flujo normal de las instrucciones. Representan condiciones de error o situaciones inesperadas que el programa debe manejar.

## Elementos

### 1. Clase Exception
- Clase base de todas las excepciones en .NET
- Propiedades principales:
    - `Message`: Descripción del error
    - `StackTrace`: Información sobre la pila de llamadas
    - `InnerException`: Excepción interna que causó la actual

### 2. Tipos de Excepciones Comunes
- `ArgumentException`: Argumento inválido
- `NullReferenceException`: Referencia nula
- `IndexOutOfRangeException`: Índice fuera de rango
- `FileNotFoundException`: Archivo no encontrado
- `DivideByZeroException`: División por cero

### 3. Excepciones Personalizadas
```csharp
public class MiExcepcionPersonalizada : Exception
{
        public MiExcepcionPersonalizada(string message) : base(message) { }
}
```

## Operaciones

### 1. Try-Catch
```csharp
try
{
        // Código que puede generar excepción
        int resultado = 10 / 0;
}
catch (DivideByZeroException ex)
{
        Console.WriteLine($"Error: {ex.Message}");
}
```

### 2. Try-Catch-Finally
```csharp
try
{
        // Código riesgoso
}
catch (Exception ex)
{
        // Manejo de excepción
}
finally
{
        // Código que siempre se ejecuta
}
```

### 3. Throw
```csharp
// Lanzar excepción
throw new ArgumentException("Argumento inválido");

// Re-lanzar excepción
catch (Exception ex)
{
        // Logging
        throw; // Preserva el stack trace
}
```

### 4. Using Statement
```csharp
using (var file = new FileStream("archivo.txt", FileMode.Open))
{
        // Uso del recurso
} // Automáticamente se llama Dispose()
```

### 5. Try-Catch con Múltiples Catch
```csharp
try
{
        // Código
}
catch (FileNotFoundException ex)
{
        // Manejo específico
}
catch (IOException ex)
{
        // Manejo para errores de I/O
}
catch (Exception ex)
{
        // Manejo general
}
```