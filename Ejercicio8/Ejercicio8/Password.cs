using System;

namespace Ejercicio8
{
    class Password
    {
        static void Main(string[] args)
        {
            Password p = new Password(15);
            Console.WriteLine("Contraseña: {0}", p.contraseña);

            Password p1 = new Password(5);
            Console.WriteLine("Contraseña: {0}", p1.contraseña);

        }

        private int longitud = 8;
        private string contraseña;

        public Password()
        {
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
            this.contraseña = getContra();

        }

        private String getContra()
        {
            Random rnd = new Random();
            string pwd="";
            string caracter = " !#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";
            char letra;

            for (int i = 0; i < longitud; i++)
            {
                letra = caracter[rnd.Next(caracter.Length)];
                pwd += letra.ToString();
            }
            return pwd;
        }

    }
}
