using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Serie s1 = new Serie();
            Serie s2 = new Serie("Los Simpsons", "Matt Groening");
            Serie s3 = new Serie("Mr. Robot", "Drama", "Sam Esmail",  4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

        }
    }
}
