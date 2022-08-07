using System;

namespace Ejercicio_Matriz
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n>--> 2. Calcular el elemento mayor de la diagonal principal de una matriz de 8x8, \nluego calcular el elemento menor de diagonal secundaria. Imprimir las posiciones en las que se encuentran. \nImprimir los elementos que están en las posiciones pares (la suma de fila + columna es par).");
            Random aleatorio = new Random();
            int[,] matriz = new int[8, 8];

            Console.WriteLine("\n>--> Matriz original<--<");
            int mayor = 10, filMay = 0, colMay = 0;
            int menor = 99, filMen = 0, colMen = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    matriz[i, j] = aleatorio.Next(10, 100);
                    Console.Write($" {matriz[i, j]} ");
                    if (i == j && matriz[i, j] > mayor)
                    {
                        mayor = matriz[i, j];
                        filMay = i;
                        colMay = j;
                    }
                    if ((i + j) == 7 && matriz[i, j] < menor)
                    {
                        menor = matriz[i, j];
                        filMen = i;
                        colMen = j;
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n>--> Matriz diagonal principal <--<");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == j)
                        if (matriz[i, j] == mayor)
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                        else
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                    else
                        Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write($" {matriz[i, j]} ");
                }
                Console.WriteLine("");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"\n--> Elemento mayor diagonal principal : {mayor} ubicado en coordenadas [{filMay}, {colMay}]");
            Console.WriteLine("");

            Console.WriteLine("\n>--> Matriz diagonal secundaria <--<");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    if ((i + j) == 7)
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                    if (matriz[i, j] == menor && (i + j) == 7)
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write($" {matriz[i, j]} ");
                }
                Console.WriteLine("");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"\n--> Elemento menor diagonal secundaria: {menor} ubicado en coordenadas [{filMen}, {colMen}]");
            Console.WriteLine("");

            Console.WriteLine("\n>--> Elementos posiciones pares <--<");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                    else
                        Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write($" {matriz[i, j]} ");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("");
            }
        }
    }
}
