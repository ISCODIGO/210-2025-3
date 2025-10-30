# Programación Orientada a Objetos

## Modificadores de Acceso y Características Especiales

### readonly
- Campos que solo pueden ser asignados durante la declaración o en el constructor
- Garantiza inmutabilidad después de la inicialización
```csharp
private readonly string _nombre;
```

### static
- Miembros que pertenecen a la clase en lugar de a instancias específicas
- Se comparten entre todas las instancias
```csharp
public static int Contador { get; set; }
public static void MetodoEstatico() { }
```

### Modificadores de Acceso
#### Concepto General
- Los modificadores de acceso controlan la visibilidad y accesibilidad de clases, métodos, propiedades y campos
- Determinan desde dónde se puede acceder a los miembros de una clase
- Son fundamentales para implementar el principio de encapsulación en POO
- Ayudan a crear APIs claras y seguras al exponer solo lo necesario

```csharp
// Ejemplo de encapsulación con diferentes modificadores
public class Persona
{
    private string _documento;      // Solo accesible internamente
    protected string _apellido;     // Accesible en clases derivadas
    public string Nombre { get; set; }  // Accesible desde cualquier lugar
}
```
#### public
- Accesible desde cualquier lugar
```csharp
public class ClasePublica { }
```

#### private
- Accesible solo dentro de la misma clase
```csharp
private int _campo;
```

#### protected
- Accesible dentro de la clase y sus clases derivadas
```csharp
protected void MetodoProtegido() { }
```

#### internal
- Modificador de acceso que limita la visibilidad al ensamblado actual
- Útil para componentes internos del proyecto
```csharp
internal class ClaseInterna { }
```

#### protected internal
- Accesible desde el mismo ensamblado o clases derivadas
```csharp
protected internal void Metodo() { }
```

#### private protected
- Accesible solo desde clases derivadas dentro del mismo ensamblado
```csharp
private protected void Metodo() { }
```

### const
- Valores constantes conocidos en tiempo de compilación
- Implícitamente static
```csharp
public const double PI = 3.14159;
```

### virtual/override/new
#### virtual
- Permite que un método sea sobrescrito en clases derivadas
```csharp
public virtual void Metodo() { }
```

#### override
- Sobrescribe un método virtual de la clase base
```csharp
public override void Metodo() { }
```

#### new (hidden)
- Oculta un miembro de la clase base sin sobrescribirlo
```csharp
public new void Metodo() { }
```

### abstract
- Clases base que no pueden ser instanciadas
- Métodos que deben ser implementados por clases derivadas
```csharp
public abstract class ClaseAbstracta
{
    public abstract void MetodoAbstracto();
}
```

## Propiedades

### Propiedades Automáticas
- Simplificación de campos privados con getter y setter automáticos
```csharp
public string Nombre { get; set; }
public int Edad { get; private set; } // setter privado
```

### Propiedades con Lógica Personalizada
- Control total sobre la asignación y obtención de valores
```csharp
private string _email;
public string Email 
{ 
    get { return _email; }
    set { _email = value?.ToLower(); }
}
```

### Propiedades de Solo Lectura
```csharp
public string NombreCompleto { get; } // solo getter
public DateTime FechaCreacion { get; } = DateTime.Now; // inicializada
```

### ¿Qué es un Constructor?
- Método especial que se ejecuta automáticamente al crear una instancia de una clase
- Su propósito es inicializar el objeto con valores apropiados
- Tiene el mismo nombre que la clase y no retorna ningún valor
- Se invoca usando la palabra clave `new`

```csharp
// Ejemplo de uso
Persona persona = new Persona("Juan", 25); // Se ejecuta el constructor
```


### Constructor por Defecto
```csharp
public Persona()
{
    Nombre = "Sin nombre";
    Edad = 0;
}
```

### Constructor Parametrizado
```csharp
public Persona(string nombre, int edad)
{
    Nombre = nombre;
    Edad = edad;
}
```

### Sobrecarga de Constructores
```csharp
public Persona(string nombre) : this(nombre, 0) { }
```

### Constructor Estático
- Se ejecuta una sola vez al acceder por primera vez a la clase
```csharp
static Persona()
{
    Contador = 0;
}
```

### Constructores con Herencia
```csharp
public Estudiante(string nombre, string carrera) : base(nombre)
{
    Carrera = carrera;
}
```

## Expresiones Lambda y Propiedades Calculadas

### ¿Qué son las Expresiones Lambda?
- Funciones anónimas que permiten escribir código más conciso
- Utilizan el operador `=>` (se lee como "va a" o "produce")
- Útiles para crear delegados y expresiones de forma compacta

### Sintaxis Básica
```csharp
// Forma tradicional
public int Sumar(int a, int b) { return a + b; }

// Con lambda
Func<int, int, int> sumar = (a, b) => a + b;
```

### Propiedades Calculadas con Lambda
```csharp
public int Edad => DateTime.Now.Year - FechaNacimiento.Year;
```

### Getters y Setters con Lambda
```csharp
public string Email 
{ 
    get => _email; 
    set => _email = value?.ToLower(); 
}
```