using System;

namespace Banco.Clientes
{
    /// <summary>
    /// Representa un cliente del banco con sus datos personales y métodos de validación
    /// </summary>
    public class Cliente
    {
        #region Campos privados
        private string nombre;
        private string codigo;
        private string identidad;
        private string telefono;
        private TipoCliente tipo;
        private DateTime fechaIngreso;
        
        // Campo estático para generar códigos únicos secuenciales
        private static int secuencia;
        #endregion

        #region Propiedades públicas
        /// <summary>
        /// Email del cliente (solo lectura desde el exterior)
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Número de identidad del cliente con validación de 13 dígitos
        /// </summary>
        public string Identidad
        {
            get => identidad;
            set
            {
                // Validar que la identidad tenga exactamente 13 caracteres
                if (value?.Length == 13)
                {
                    identidad = value;
                }
                else
                {
                    Console.WriteLine("Error: La identidad debe tener exactamente 13 caracteres");
                }
            }
        }

        /// <summary>
        /// Código único del cliente (solo lectura)
        /// </summary>
        public string Codigo => codigo;
        #endregion

        #region Constructor
        /// <summary>
        /// Crea una nueva instancia de Cliente con los datos proporcionados
        /// </summary>
        /// <param name="nombre">Nombre completo del cliente</param>
        /// <param name="identidad">Número de identidad (13 dígitos)</param>
        /// <param name="telefono">Número de teléfono (8 dígitos)</param>
        /// <param name="email">Dirección de correo electrónico</param>
        public Cliente(string nombre, string identidad, string telefono, string email)
        {
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.Identidad = identidad; // Usa la propiedad para validación
            this.SetTelefono(telefono);
            this.Email = email ?? throw new ArgumentNullException(nameof(email));

            // Inicializar campos automáticos
            this.fechaIngreso = DateTime.Now;
            this.codigo = $"CLIENTE-{++secuencia:D4}"; // Formato: CLIENTE-0001
            this.tipo = TipoCliente.PERSONAL;
        }
        #endregion

        #region Métodos públicos
        /// <summary>
        /// Devuelve el teléfono formateado con guión (ej: 1234-5678)
        /// </summary>
        /// <returns>Teléfono formateado o cadena original si no tiene 8 dígitos</returns>
        public string GetTelefono()
        {
            // Formatear teléfono de 8 dígitos con guión en el medio
            if (telefono?.Length == 8)
            {
                return $"{telefono.Substring(0, 4)}-{telefono.Substring(4, 4)}";
            }
            return telefono ?? string.Empty;
        }

        /// <summary>
        /// Establece el número de teléfono removiendo espacios y guiones
        /// </summary>
        /// <param name="telefono">Número de teléfono a establecer</param>
        public void SetTelefono(string telefono)
        {
            if (telefono == null)
            {
                this.telefono = string.Empty;
                return;
            }

            // Limpiar el teléfono removiendo guiones y espacios
            var telefonoLimpio = telefono.Replace("-", "").Replace(" ", "");
            
            // Validar que tenga exactamente 8 dígitos
            if (telefonoLimpio.Length == 8 && telefonoLimpio.All(char.IsDigit))
            {
                this.telefono = telefonoLimpio;
            }
            else
            {
                this.telefono = string.Empty;
                Console.WriteLine("Error: El teléfono debe tener exactamente 8 dígitos");
            }
        }

        /// <summary>
        /// Representación en cadena del cliente
        /// </summary>
        /// <returns>Cadena con código, nombre y tipo de cliente</returns>
        public override string ToString()
        {
            return $"{codigo}: {nombre} - {tipo}";
        }

        /// <summary>
        /// Obtiene el código único del cliente
        /// </summary>
        /// <returns>Código del cliente</returns>
        public string GetCodigo()
        {
            return codigo;
        }
        #endregion
    }
}