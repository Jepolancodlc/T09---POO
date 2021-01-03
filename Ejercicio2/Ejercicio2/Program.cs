using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado e = new Empleado("Pedro", 2321);
            Empleado e1 = new Empleado("Marrco", 8323);
            e.imprime();
            e.pagarImpuestos();
            Console.WriteLine(" ");
            e1.imprime();
            e1.pagarImpuestos();
        }
    }
}
