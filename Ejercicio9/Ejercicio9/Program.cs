using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico e1 = new Electrodomestico();
            Electrodomestico e2 = new Electrodomestico(230, 60.34);
            Electrodomestico e3 = new Electrodomestico(500, "rojo", 'A', 80.94);

            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
        }
    }
}
