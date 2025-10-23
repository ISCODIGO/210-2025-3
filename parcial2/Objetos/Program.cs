class Program 
{
    public static void Main(string[] args) {
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
    }
}