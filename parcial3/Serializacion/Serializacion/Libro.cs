using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    internal class Libro
    {
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public string Isbn { get; set; }
        public int AñoPublicacion { get; set; }

        public Libro(string titulo, string autor, string isbn, int añoPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            Isbn = isbn;
            AñoPublicacion = añoPublicacion;
        }

        public override string ToString()
        {
            return $"{Titulo} ({Autor})";
        }
    }
}
