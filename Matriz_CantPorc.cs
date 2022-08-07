using System;

namespace Matriz_CantPorc
{

    /*Determinar la cantidad y el porcentaje de elementos pares e impares de una matriz de NxM. Así como la suma y el promedio de los elementos de la matriz.
     * 
     * */
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont1 = 0, suma=0, sumaImpar=0, cont2=0;
            Console.Write("Ingrese la cantidad de filas [F]: ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la cantidad de columnas [C]: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[f, c];
            // Llenar matriz con numeros random
            Random rand = new Random(); 
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matriz[i, j] = rand.Next(0, 101);
                }
            }
            // Imprimir matriz
            Console.WriteLine("\n");
            Console.WriteLine("La matriz: ");
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"{matriz[i,j]} ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("\n");
            // Calcular numeros pares e impares
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (matriz[i, j] % 2 == 0)
                    {
                        suma += matriz[i, j];
                        cont1++;
                    }
                    else
                    {
                        sumaImpar += matriz[i, j];
                        cont2++;
                    }
                }
            }
            Console.WriteLine($"La suma de los numeros pares es:                 {suma}");
            Console.WriteLine($"La suma de los numeros impares es:               {sumaImpar}");
            Console.WriteLine($"La cantidad de los numeros pares es:             {cont1}");
            Console.WriteLine($"La cantidad de los numeros impares es:           {cont2}");
            Console.WriteLine($"Resultado promedio:                              {(double)suma / (f*c):F2}.");
            Console.WriteLine($"Porcentaje de elementos pares:                   {(double)cont1 / (f * c):P2}.");
            Console.WriteLine($"Porcentaje de elementos impares:                 {(double)cont2 / (f * c):P2}.");

        }
    }
}
