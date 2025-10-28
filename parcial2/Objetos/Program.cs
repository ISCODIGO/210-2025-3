using Objetos;

class Program 
{
    public static void Main(string[] args)
    {
        Cliente c01 = new Cliente(
            "Jose Martinez",
            "0801199012377",
            "99991238",
            "jmartinez@unah.hn"
        );

        Cliente c02 = new Cliente(
                    "Jose Martinez",
                    "0801199012377",
                    "99991238",
                    "jmartinez@unah.hn"
                );


        Console.WriteLine("---------");
        Console.WriteLine(c01);
        Console.WriteLine(c01.GetTelefono());
        Console.WriteLine(c02);
        // c02.Email = "hola@unah.hn";
        Console.WriteLine(c02.Email);

        Cuenta cuenta = new Cuenta(c01, TipoCuenta.AHORRO, 1500);
        cuenta.Depositar(1000);
        cuenta.Depositar(500);
        Console.WriteLine(cuenta);
    }
}