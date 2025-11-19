using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    internal class Libreria
    {
        public string Nombre {  get; set; }
        public Libro[] Libros {  get; set; }
        public int PosicionActual { get; set; } = 0;

        public Libreria(string nombre, int capacidad)
        {
            Nombre = nombre;
            Libros = new Libro[capacidad];
        }

        public void AgregarLibro(Libro libro)
        {
            if (PosicionActual >= Libros.Length)
            {
                throw new Exception("No se puede agregar mas libros");
            }

            Libros[PosicionActual++] = libro;
        }

        public void ImprimirLibros()
        {
            foreach (Libro libro in Libros)
            {
                if (libro != null)
                {
                    Console.WriteLine(libro);
                }
            }
        }
    }
}
