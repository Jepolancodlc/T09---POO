using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Operaciones
    {
        int num1, num2;
        int total=0;
        public Operaciones()
        {
        }

        public Operaciones(int num1, int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }


        public void suma()
        {
            total = num1 + num2;
            Console.WriteLine("El total de la suma es: " + total);
        }
        public void resta()
        {
            total = num1 - num2;
            Console.WriteLine("El total de la resta es: " + total);
        }
        public void multi()
        {
            total = num1 * num2;
            Console.WriteLine("El total de la multiplicacion es: " + total);
        }
        public void div()
        {
            total = num1 / num2;
            Console.WriteLine("El total de la division es: " + total);
        }

    }

    
}
