using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_10
{
    class Serie
    {
        string titulo, genero, creador;
        int nTemp=3;
        bool entregado=false;

        public Serie()
        {
        }

        public Serie(string titulo, string creador)
        {
            this.Titulo = titulo;
            this.Creador = creador;
        }

        public Serie(string titulo, string genero, string creador, int nTemp) : this(titulo, genero)
        {
            this.Creador = creador;
            this.NTemp = nTemp;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Creador { get => creador; set => creador = value; }
        public int NTemp { get => nTemp; set => nTemp = value; }
        public bool Entregado { get => entregado; set => entregado = value; }

        public override string ToString()
        {
            return String.Format("Titulo: {0} | Genero:{1} | Creador:{2} | Numeros de temporada:{3} | Entregado?:{4}", titulo, genero, creador, nTemp,entregado);
        }
    }
}
