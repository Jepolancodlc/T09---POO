using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Alumno
    {
        private string nombre;
        private int edad;

        public Alumno()
        {
        }

        public Alumno(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public void esMayor()
        {
            if (edad >= 18)
            { 
               Console.Write("{0} es mayor de edad.", nombre);
            }
            else
            {
                Console.Write("{0} no es mayor de edad.", nombre);
            }
        }

        public void imprime()
        {
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("Edad:" + edad);
        }
    }
}
