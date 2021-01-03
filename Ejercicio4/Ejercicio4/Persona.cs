using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    class Persona
    {
        private string nombre;

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void saludar()
        {
            Console.WriteLine("Hola soy " + nombre);
        }
    }
}
