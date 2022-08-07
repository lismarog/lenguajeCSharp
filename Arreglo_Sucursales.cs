using System;

namespace Arreglo_Sucursales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de productos en la sucursal de Bogotá [N]: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Random r = new Random();
            int[] sucursal_Bog = new int[n];

            for (int i = 0; i < sucursal_Bog.Length; i++){
                sucursal_Bog[i] = r.Next(100, 900);
                Console.WriteLine($"El numero del producto en la sucursal de Bogota [{i + 1}] = {sucursal_Bog[i]} ");
            }
            Console.Write("\n");
            Console.Write("Ingrese la cantidad de productos en la sucursal de Medellin [M]: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            int[] sucursal_Med = new int[m];

            for (int i = 0; i < sucursal_Med.Length; i++)
            {
                sucursal_Med[i] = r.Next(100, 900);
                Console.WriteLine($"El numero del producto en la sucursal de Medellin [{i + 1}] = {sucursal_Med[i]} ");
            }
            // Ordenamiento por burbuja optimizado 

            bool band = true;
            for (int i = 0; i < sucursal_Med.Length && band; i++)
            {
                band = false;
                for (int j = 0; j < sucursal_Med.Length - i - 1; j++)
                {
                    if (sucursal_Med[j] > sucursal_Med[j + 1])
                    {
                        int aux = sucursal_Med[j];
                        sucursal_Med[j] = sucursal_Med[j + 1];
                        sucursal_Med[j + 1] = aux;
                        band = true;
                    }
                }
            }

            Console.WriteLine("\n Productos de sucursal Medellin ordenados de manera ascendente ");
            for (int i = 0; i < sucursal_Med.Length; i++)
                Console.WriteLine($"# del producto [{i + 1}] = {sucursal_Med[i]} ");
            // Buscar el numero mayor
            double may = sucursal_Med[0];
            int pos = 0;
            int suma = 0;
            for (int i = 0; i < sucursal_Med.Length; i++)
            {
                if (sucursal_Med[i] > may)
                    may = sucursal_Med[i];
                    pos = i;
                 suma += sucursal_Med[i]; // acumulador de valores en vector
            }
            // Buscar el numero menor
            double men = 899;
            int pos2 = 0;
            int sum = 0;
            for (int i = 0; i < sucursal_Bog.Length; i++)
            {
                if (sucursal_Bog[i] < men)
                    men = sucursal_Bog[i];
                    pos2 = i;
                     sum += sucursal_Bog[i]; // acumulador de valores en vector
            }
            Console.WriteLine($"\nEl numero mayor en la sucursal de Medellin es: {may}. Se encuentra en la posicion {pos + 1} ");
            Console.WriteLine($"El numero menor en la sucursal de Bogota es: {men}. Se encuentra en la posicion {pos2+1}");
            Console.WriteLine($"La suma de todos los producto es:  {suma+sum} ");
            Console.WriteLine($"Promedio de números en Bogota: {(double)sum / n:F2}");
            Console.WriteLine($"Promedio de números en Medellin: {(double)suma / m:F2}");
            Console.WriteLine($"\n");

            // Busqueda secuencial optimizada
            int clave;
            while (true)
            {
                Console.Write("\n Ingrese la clave a buscar en la sucursal de Bogotá 0 para salir: ");
                clave = Convert.ToInt32(Console.ReadLine());
                if (clave == 0) break;
                int posicion = -1;
                for (int i = 0; i < sucursal_Bog.Length; i++)
                {
                    if (sucursal_Bog[i] == clave)
                    {
                        posicion = i;
                        break;
                    }
                }
                if (posicion != -1)
                    Console.WriteLine($"\n El numero existe en la posicion  {posicion + 1}");
                else
                    Console.WriteLine($"\n El numero no existe");
            }
            Console.WriteLine($"\n");
            // Busqueda binaria en sucursal de medellin
            while (true)
            {
                Console.Write("\n Digite clave a buscar en la sucursal de Medellin o 0 para salir: ");
                clave = Convert.ToInt32(Console.ReadLine());
                if( clave == 0) break ;
                int izq = 0, der = sucursal_Med.Length - 1, mit = (izq + der) / 2;
                while (sucursal_Med[mit] != clave && izq <= der)
                {
                    if (clave > sucursal_Med[mit])
                        izq = mit + 1;
                    else
                        der = mit - 1;
                    mit = (izq + der) / 2;
                }
                if (sucursal_Med[mit] == clave)
                    Console.WriteLine($"{clave} Encontrado en la posición {mit + 1}.");
                else
                    Console.WriteLine($"No existe {clave}.");
            }
         }  
       }
    }
