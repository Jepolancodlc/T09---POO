using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    class Libro
    {
        string autor, titulo, ubicacion;
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }

        static void Main(string[] args)
        {
            Libro l = new Libro();

            l.autor = "Stephen King";
            l.titulo = "It";
            l.ubicacion = "Algun lugar de Estados Unidos";

            Console.WriteLine("Autor: "+l.autor);
            Console.WriteLine("Titulo: "+l.titulo);
            Console.WriteLine("Ubicacion: "+l.ubicacion);
        }
    }
}
