namespace Banco.Cuentas
{
    

    /// <summary>
    /// Clase que representa una cuenta bancaria
    /// </summary>
    internal class Cuenta
    {
        // Contador estático para generar códigos únicos secuenciales
        private static int secuencia;
        
        // Cliente propietario de la cuenta (inmutable)
        private readonly Clientes.Cliente propietario;
        
        // Saldo actual de la cuenta
        private decimal saldo;
        
        // Fecha de creación de la cuenta (inmutable)
        private readonly DateTime fechaCreacion;

        /// <summary>
        /// Código único de identificación de la cuenta
        /// </summary>
        public string Codigo { get; private set; }
        
        /// <summary>
        /// Tipo de cuenta (ahorro o cheque)
        /// </summary>
        public TipoCuenta Tipo { get; private set; }
        
        /// <summary>
        /// Saldo actual de la cuenta (solo lectura)
        /// </summary>
        public decimal Saldo => saldo;
        
        /// <summary>
        /// Fecha de creación de la cuenta (solo lectura)
        /// </summary>
        public DateTime FechaCreacion => fechaCreacion;
        
        /// <summary>
        /// Cliente propietario de la cuenta (solo lectura)
        /// </summary>
        public Clientes.Cliente Propietario => propietario;

        /// <summary>
        /// Constructor para crear una nueva cuenta bancaria
        /// </summary>
        /// <param name="cliente">Cliente propietario de la cuenta</param>
        /// <param name="tipo">Tipo de cuenta a crear</param>
        /// <param name="saldoInicial">Saldo inicial (opcional, por defecto 0)</param>
        /// <exception cref="ArgumentNullException">Se lanza cuando el cliente es null</exception>
        /// <exception cref="ArgumentException">Se lanza cuando el saldo inicial es negativo</exception>
        public Cuenta(Clientes.Cliente cliente, TipoCuenta tipo, decimal saldoInicial = 0)
        {
            // Validar que el cliente no sea null
            if (cliente == null)
                throw new ArgumentNullException(nameof(cliente));
            
            // Validar que el saldo inicial no sea negativo
            if (saldoInicial < 0)
                throw new ArgumentException("El saldo inicial no puede ser negativo", nameof(saldoInicial));

            // Asignar valores a las propiedades
            this.propietario = cliente;
            this.Tipo = tipo;
            this.saldo = saldoInicial;
            this.fechaCreacion = DateTime.Now;
            
            // Generar código único con formato CTA-TIPO-0000001
            this.Codigo = $"CTA-{tipo}-{++secuencia:D7}";
        }

        /// <summary>
        /// Representación en texto de la cuenta
        /// </summary>
        /// <returns>Cadena con información básica de la cuenta</returns>
        public override string ToString()
        {
            var codigoCliente = propietario.GetCodigo();
            return $"{Codigo} L{saldo:N2} propiedad de [{codigoCliente}]";
        }

        /// <summary>
        /// Deposita dinero en la cuenta
        /// </summary>
        /// <param name="monto">Cantidad a depositar</param>
        /// <exception cref="ArgumentException">Se lanza cuando el monto es menor o igual a cero o excede L150,000</exception>
        public void Depositar(decimal monto)
        {
            // Validar que el monto sea positivo y no exceda el límite de 150,000
            if (monto <= 0 || monto > 150_000)
            {
                throw new ArgumentException("El monto a depositar debe ser positivo y no exceder L150,000.", nameof(monto));
            }

            // Aumentar el saldo
            this.saldo += monto;
        }

        /// <summary>
        /// Retira dinero de la cuenta
        /// </summary>
        /// <param name="monto">Cantidad a retirar</param>
        /// <exception cref="ArgumentException">Se lanza cuando el monto es menor o igual a cero o cuando no hay fondos suficientes</exception>
        public void Retirar(decimal monto)
        {
            // Validar que el monto sea positivo y no exceda el saldo disponible
            if (monto <= 0)
            {
                throw new ArgumentException("El monto a retirar debe ser positivo.", nameof(monto));
            }

            if (monto > this.saldo)
            {
                throw new ArgumentException("Fondos insuficientes para realizar el retiro.", nameof(monto));
            }

            // Disminuir el saldo
            this.saldo -= monto;
        }
    }
}
