using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relojes
{
    public class Reloj
    {
        private int _horas;
        private int _minutos;
        private int _segundos;

        public const int MAX_HORA = 23;
        public const int MAX_MINUTOS = 59;

        public int Hora {
            get
            {
                return _horas;
            }
            set
            {
                if (value >= 0 && value <= MAX_HORA)
                {
                    _horas = value;
                } else {
                    throw new ArgumentOutOfRangeException($"La hora no es valida [0-{MAX_HORA}]");
                }
            }
        }
        public int Minutos
        {
            get
            {
                return _minutos;
            }

            set
            {
                if (value < 0 || value > MAX_MINUTOS)
                {
                    throw new MinutoException($"Los minutos no es valida [0-{MAX_MINUTOS}]");
                }
            }
        }
        public int Segundos { get; set; }

        public Reloj() 
        { 
            Hora = 0;
            Minutos = 0;
            Segundos = 0;
        }

        public Reloj(int hora, int minutos, int segundos)
        {
            Hora = hora;
            Minutos = minutos;
            Segundos = segundos;
        }
    }
}
