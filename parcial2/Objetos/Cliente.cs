public enum TipoCliente
{
    NORMAL, EMPRESARIAL
}

public class Cliente
{
    // atributos
    private string nombre;
    private string codigo;
    public string identidad;
    private string telefono;
    private string Email
    {
        get; set;
    }

    private TipoCliente tipo;
    private DateTime fechaIngreso;

    // propiedad
    public string Identidad
    {
        get
        {
            return identidad;
        }
        
        set
        {
            Console.WriteLine("set...");
            if (value.Length == 13)
            {
                identidad = value;
            }
            else
            {
                Console.WriteLine("Esta identidad no es correcta");
            }
        }
    }

    private static int secuencia;  // pertenece a la clase

    public Cliente(string nombre, string identidad, string telefono, string email)
    {
        // this sirve como una referencia al propio objeto
        this.nombre = nombre;
        this.Identidad = identidad;
        SetTelefono(telefono);
        this.Email = email;

        this.fechaIngreso = DateTime.Now;
        this.codigo = $"CLIENTE-{++secuencia}";
        this.tipo = TipoCliente.NORMAL;
    }

    public override string ToString()
    {
        return $"{codigo}: {nombre} - {this.tipo}";
    }

    public string GetTelefono()
    {
        // Para la lectura del atributo telefono
        if (telefono.Length == 8)
        {
            string parte1 = telefono.Substring(0, 4);
            string parte2 = telefono.Substring(4, 4);
            return parte1 + "-" + parte2;
        }
        return telefono;
    }

    public void SetTelefono(string telefono)
    {
        var copiaTelefono = telefono.Replace("-", "").Replace(" ", "");
        if (copiaTelefono.Length == 8)
        {
            this.telefono = copiaTelefono;
        } else
        {
            this.telefono = string.Empty;
        }


    }


}