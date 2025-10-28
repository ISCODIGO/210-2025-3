using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public enum TipoCuenta
    {
        AHORRO, CHEQUE
    }
    internal class Cuenta
    {
        private static int secuencia;
        private Cliente propietario;
        private decimal saldo;
        public string Codigo { get; private set; }
        public TipoCuenta Tipo
        {
            get; set;
        }

        private DateTime fechaCreacion;

        public Cuenta(Cliente cliente, TipoCuenta tipo, decimal saldoInicial)
        {
            this.propietario = cliente;
            this.Tipo = tipo;
            this.saldo = saldoInicial;
            this.fechaCreacion = DateTime.Now;
            this.Codigo = $"CTA-{tipo}-{++secuencia}";
        }

        public override string ToString()
        {
            return $"{Codigo} L{saldo} propiedad de [{this.propietario.GetCodigo()}]";
        }

        public void Depositar(decimal monto)
        {
            if (monto <= 0)
            {
                return;
            }

            if (monto > 150_000)
            {
                return;
            }

            this.saldo += monto;
        }
    }
}
