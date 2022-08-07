using System;

/*3.	Llenar una matriz de 6x6 números aleatorios entre 10 y 99. Determinar la suma de las filas impares y 
 * la cantidad de elementos impares que hay en las filas pares. Leer un número, buscarlo e imprimir si existe o no. 
 * En caso de encontrarlo, imprimir la posición o coordenada en la que se encuentra (fila y columna).
 * 
 * */
namespace Matriz_Operaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[6, 6];
            int sumaImpar = 0, cont=0;
            // Llenar matriz con numeros random
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    matriz[i, j] = rand.Next(10, 100);
            }
            // Imprimir matriz
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write($"{matriz[i, j]} ");
                Console.WriteLine(" ");
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if ((i % 2) != 0)
                        sumaImpar += matriz[i, j];
                    else
                    {
                        if (matriz[i, j] % 2 != 0)
                            cont++;
                    }
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine($"La suma de los numeros impares es:           {sumaImpar}");
            Console.WriteLine($"Cantidad de elementos impares en filas pares: {cont}");
            Console.WriteLine("\n");
            while (true)
            {
                Console.Write("Ingrese la clave a buscar o -1: ");
                int clave = Convert.ToInt32(Console.ReadLine());
                if (clave == -1) break;
                bool band = false;
                int posi = -1;
                int posj = -1;
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {

                        if (matriz[i, j] == clave)
                        {
                            posi = i;
                            posj = j;
                            band = true; break;
                        }
                    }
                }
                if (band == true)
                    Console.WriteLine($"EXISTE EN FILA [{posi + 1}] COLUMNA [{posj + 1}]");
                else
                    Console.WriteLine($"NO EXISTE");
            }
        }
    }
}
