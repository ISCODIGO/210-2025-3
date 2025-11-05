namespace Relojes;

public class MinutoException : Exception
{

    // constructor se puede usar base para indicar que se
    // usa el constructor de la clase base (Exception)
    public MinutoException(string mensaje) : base(mensaje)
    {
    }
}