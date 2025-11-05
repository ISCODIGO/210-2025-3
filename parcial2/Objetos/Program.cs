using Banco.Cuentas;
using Banco.Clientes;

class Program
{
    public static void Main(string[] args)
    {
        // Crear primer cliente con información personal completa
        Cliente cliente1 = new Cliente(
            "Jose Martinez",
            "0801199012377",
            "99991238",
            "jmartinez@unah.hn"
        );

        // Crear segundo cliente con la misma información (posible duplicado)
        Cliente cliente2 = new Cliente(
            "Ana Rodriguez",
            "0801199012378",
            "99991239",
            "arodriguez@unah.hn"
        );

        // Mostrar información de los clientes
        MostrarInformacionClientes(cliente1, cliente2);

        // Crear cuenta de ahorros para el primer cliente con saldo inicial
        Cuenta cuentaAhorros = new Cuenta(cliente1, TipoCuenta.AHORRO, 1500.1294m);
        
        // Realizar operaciones bancarias
        RealizarOperacionesBancarias(cuentaAhorros);
        
        // Mostrar estado final de la cuenta
        Console.WriteLine("Estado final de la cuenta:");
        Console.WriteLine(cuentaAhorros);
    }

    /// <summary>
    /// Muestra la información de los clientes en consola
    /// </summary>
    /// <param name="cliente1">Primer cliente</param>
    /// <param name="cliente2">Segundo cliente</param>
    private static void MostrarInformacionClientes(Cliente cliente1, Cliente cliente2)
    {
        Console.WriteLine("========== INFORMACIÓN DE CLIENTES ==========");
        Console.WriteLine($"Cliente 1: {cliente1}");
        Console.WriteLine($"Teléfono: {cliente1.GetTelefono()}");
        Console.WriteLine();
        Console.WriteLine($"Cliente 2: {cliente2}");
        Console.WriteLine($"Email: {cliente2.Email}");
        Console.WriteLine("==============================================");
    }

    /// <summary>
    /// Realiza operaciones de depósito en la cuenta
    /// </summary>
    /// <param name="cuenta">Cuenta donde realizar las operaciones</param>
    private static void RealizarOperacionesBancarias(Cuenta cuenta)
    {
        Console.WriteLine("\n========== OPERACIONES BANCARIAS ==========");
        
        // Intentar depósito con monto negativo (debería fallar)
        Console.WriteLine("Intentando depósito de -1000...");
        cuenta.Depositar(-1000);
        
        // Realizar depósito válido
        Console.WriteLine("Realizando depósito de 500...");
        cuenta.Depositar(500);
        Console.WriteLine("==========================================");
    }
}