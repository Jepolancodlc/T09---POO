using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    class Empleado
    {
        string nombre;
        double sueldo;

        public Empleado()
        {
        }

        public Empleado(string nombre, double sueldo)
        {
            this.Nombre = nombre;
            this.Sueldo = sueldo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public void imprime()
        {
            Console.WriteLine("Nombre: "+nombre);
            Console.WriteLine("Sueldo: {0} euros",Sueldo);
        }

        public void pagarImpuestos()
        {
            if (sueldo >= 3000)
            {
                Console.WriteLine("Ha de pagar impuestos");
            }
            else
            {
                Console.WriteLine("No ha de pagar impuestos");
            }
        }
    }
}
