using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones o = new Operaciones(10, 5);
            o.suma();
            o.resta();
            o.multi();
            o.div();
        }
    }
}
