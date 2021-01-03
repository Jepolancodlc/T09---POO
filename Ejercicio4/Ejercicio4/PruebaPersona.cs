using System;

namespace Ejercicio4
{
    class PruebaPersona
    {
        static void Main(string[] args)
        {
            Persona a = new Persona();
            Persona b = new Persona();

            a.setNombre("Juan");
            b.setNombre("David");

            a.saludar();
            b.saludar();


        }
    }
}