using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem03_02
{
    internal class Program
    {
        static void Main(string[] args)
        {// Solicitar al usuario la categoría del hotel y la duración de la estadía en días
            Console.WriteLine("Ingrese la categoría del hotel (3 estrellas o 5 estrellas):");
            string categoriaHotel = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad de días de estadía:");
            int diasEstadia = int.Parse(Console.ReadLine());

            // Definir los precios base por día según la tabla
            double precioBasePorDia = 0;

            if (categoriaHotel.ToLower() == "3 estrellas")
            {
                if (diasEstadia >= 1 && diasEstadia <= 5)
                {
                    precioBasePorDia = 100;
                }
                else if (diasEstadia >= 6 && diasEstadia <= 10)
                {
                    precioBasePorDia = 85;
                }
                else if (diasEstadia >= 11)
                {
                    precioBasePorDia = 70;
                }
                else
                {
                    Console.WriteLine("Número de días de estadía no válido.");
                    return;
                }
            }
            else if (categoriaHotel.ToLower() == "5 estrellas")
            {
                if (diasEstadia >= 1 && diasEstadia <= 5)
                {
                    precioBasePorDia = 300;
                }
                else if (diasEstadia >= 6 && diasEstadia <= 10)
                {
                    precioBasePorDia = 270;
                }
                else if (diasEstadia >= 11)
                {
                    precioBasePorDia = 250;
                }
                else
                {
                    Console.WriteLine("Número de días de estadía no válido.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Categoría de hotel no válida.");
                return;
            }

            // Calcular el costo total, incluyendo el desayuno
            double costoPorEstadia = precioBasePorDia * diasEstadia;
            double costoTotalConDesayuno = costoPorEstadia + (7.00 * diasEstadia);

            // Mostrar el resultado
            Console.WriteLine("El costo total de la estadía es: S/ " + costoTotalConDesayuno);
        }
    }


}
    

