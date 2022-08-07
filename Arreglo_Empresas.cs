using System;

/*
 Mediante un programa en C# leer el NIT de una empresa, si se encuentra en un vector de N posiciones donde están registradas
las mejores empresas según la norma ISO9000 e imprimir “HACERLE RECONOCIMIENTO NACIONAL”. 
 * Ordenar el vector de forma descendente por el método de su preferencia.
 * */

namespace Arreglos_Empresas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Leer cantidad de empresas a registrar
            Console.Write("Ingrese la cantidad de empresas [N]: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            string[] NIT = new string[n]; // Declaracion de vector tipo string
            // Leer el NIT de la empresa
            Console.Clear();
            for (int i = 0; i < NIT.Length; i++)
            {
                Console.Write($"Ingrese el NIT de la empresa [{i + 1}]: ");
                NIT[i] = Console.ReadLine();
            }
            // Odenar vector seleccion descendente
            for (int i = 0; i < NIT.Length - 1; i++)
            {
                for (int j = i + 1; j < NIT.Length; j++)
                {
                    if (Convert.ToInt32(NIT[i]) < Convert.ToInt32(NIT[j]))
                    {
                        string aux = NIT[i];
                        NIT[i] = NIT[j];
                        NIT[j] = aux;
                    }
                }
            }
            // Imprimir vector de manera descendente
            Console.WriteLine("\nVector ordenado de manera descendente ");
            for (int i = 0; i < NIT.Length; i++)
                Console.WriteLine($"Vector en posicion [{i + 1}] = {NIT[i]} ");
            // Busqueda por metodo secuencial optimizado
            int clave;
            while (true)
            {
                Console.Write("\nIngrese la clave a buscar o 0 para salir: ");
                clave = Convert.ToInt32(Console.ReadLine());
                if (clave == 0) break;
                bool band = false;
                for (int i = 0; i < NIT.Length && band == false; i++)
                {
                    if (Convert.ToInt32(NIT[i]) == clave)
                        band = true;
                }
                // Condicional ternario para imprimir mensaje
                Console.WriteLine(band ? "\nHACERLE RECONOCIMIENTO NACIONAL\n" : "\nNO HACERLE RECONOCIMIENTO NACIONAL\n");
            }
        }
      }
    }



