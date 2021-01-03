using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio6
{
    class Coche
    {
        string marca, modelo;
        int cilindrada;
        double potencia;

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Cilindrada { get => cilindrada; set => cilindrada = value; }
        public double Potencia { get => potencia; set => potencia = value; }

        static void Main(string[] args)
        {
            Coche c = new Coche();
            c.marca = "Audi";
            c.modelo = "A7";
            c.cilindrada = 4;
            c.potencia = 400.00;

            Console.WriteLine("Marca: "+c.marca);
            Console.WriteLine("Modelo: "+c.modelo);
            Console.WriteLine("Cilindrada: {0}L",c.cilindrada);
            Console.WriteLine("Potencia:{0}CV",c.potencia);

        }
    }

}
