using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Electrodomestico
    {
		
		 int precioBase;
		 string color;
		 char consumo;
		 double peso; 
		
		//Constantes por defecto
		 string COLOR_DEF = "Blanco";
		 int PRECIO_DEF = 100;
		 char CONSUMO_DEF = 'F';
		 int PESO_DEF = 5;


		public Electrodomestico()
		{
			this.precioBase = PRECIO_DEF;
			this.color = COLOR_DEF;
			this.consumo = CONSUMO_DEF;
			this.peso = PESO_DEF;
		}

		public Electrodomestico(int precioBase, double peso)
		{
			
			this.precioBase = precioBase;
			this.peso = peso;
			this.color = COLOR_DEF;
			this.consumo = CONSUMO_DEF;

		}

		public Electrodomestico(int precioBase, string color, char consumo, double peso)
		{
		
			this.precioBase = precioBase;
			this.color = elegirColor(color);
			this.consumo = elegirEnergia(consumo);
			this.peso = peso;

		}


		private string elegirColor(string elcolor)
        {
            elcolor =elcolor.ToLower();

            switch (elcolor)
            {
                case "blanco":
                    return "Blanco";
                case "negro":
                    return "Negro";
                case "rojo":
                    return "Rojo";
                case "azul":
                    return "Azul";
                case "gris":
                    return "Gris";

                default:
                    Console.WriteLine("El color por defecto es Blanco, por favor introduzca un color correcto ");
                    break;
            }
            return elcolor;
        }

		private char elegirEnergia(char tipoDeEnergia)
		{
		
			switch (tipoDeEnergia)
			{
				case 'A':
					return 'A';
				case 'B':
					return 'B';
				case 'C':
					return 'C';
				case 'D':
					return 'D';
				case 'E':
					return 'E';
				case 'F':
					return 'F';
				default:
                    Console.WriteLine("El consumo por defecto es F, por favor seleccione un consumo energetico correcto");
					break;
			}
			return tipoDeEnergia;
		}

        public override string ToString()
        {
			return "Electrodomestico || PrecioBase: " + precioBase + "$"+" || Color: " + color + " || Consumo: " + consumo
						+ " || Peso: " + peso + "Kg" + ""
		}
	}
}
