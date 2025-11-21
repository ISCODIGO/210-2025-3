using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planilla
{
    public abstract class Empleado
    {
        public string Nombre { get; }
        public int ID { get; }

        protected Empleado(string Nombre, int ID)
        {
            this.Nombre = Nombre;
            this.ID = ID;
        }

        public abstract decimal Salario();

        public override string ToString()
        {
            decimal s = Salario();
            return $"{ID} - {Nombre} gana {s:N2}";
        }
    }

    public class EmpleadoSalario : Empleado
    {
        public decimal _salario;

        public EmpleadoSalario(string nombre, int id, decimal salario)
            : base(nombre, id)
        {
            _salario = salario;
        }

        public override decimal Salario()
        {
            return _salario;
        }
    }

    public class EmpleadoPorHora : Empleado
    {
        private decimal _valorPorHora;
        public int Horas { get; set; }

        public EmpleadoPorHora(string nombre, int id, decimal valorHora)
            : base(nombre, id)
        {
            _valorPorHora = valorHora;
            Horas = 0;
        }

        public override decimal Salario()
        {
            return Horas * _valorPorHora;
        }
    }

    public class EmpleadoComision : Empleado
    {
        private decimal _comision;
        public decimal Ventas {  get; set; }

        public EmpleadoComision(string nombre, int id, decimal comision)
            : base(nombre, id)
        {
            _comision = comision;
            Ventas = 0;
        }
        public override decimal Salario()
        {
            return Ventas * _comision / 100m;
        }
    }
}
