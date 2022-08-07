using System;

/*
 * 6.	En un arreglo de P posiciones llamado GOLEADOR_ACTUAL están los nombres de los jugadores que quedaron goleadores en el año actual y en otro arreglo de Q posiciones
 * llamado GOLEADOR_ANTERIOR están los nombres de los jugadores que quedaron goleadores el año inmediatamente anterior. Hacer un programa en C# que le permita a un entrenador 
 * leer el nombre de un jugador e imprima si puede ser seleccionado para su equipo o no. 
 * */
namespace Arreglos_Goleadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nIngrese la cantidad de jugadores[P]: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

           string[] goleador_actual = new string[p];

            for (int i = 0; i < goleador_actual.Length; i++) {
                Console.Write($"Ingrese el nombre del jugador del año actual [{i + 1}]: ");
                goleador_actual[i] = (Console.ReadLine());
            }
            Console.Write("\nIngrese la cantidad de jugadores[Q]: ");
            int q = Convert.ToInt32(Console.ReadLine());
            string[] goleador_anterior = new string[q];
            Console.Write("\n");
            for (int i = 0; i < goleador_anterior.Length; i++) {
                Console.Write($"Ingrese el nombre del jugador del año anterior [{i + 1}]: ");
                goleador_anterior[i] = (Console.ReadLine());
            }
            //Metodo ordenamiento seleccion ascendente tipo string
            for (int i = 0; i < goleador_actual.Length - 1; i++) {
                for (int j = i + 1; j < goleador_actual.Length; j++) {
                    if (goleador_actual[i].CompareTo(goleador_actual[j]) > 0) {
                        string aux = goleador_actual[i];
                        goleador_actual[i] = goleador_actual[j];
                        goleador_actual[j] = aux;
                    }
                }
            }

            Console.WriteLine("\nVector organizado: ");
            for (int i = 0; i < goleador_actual.Length; i++)
                Console.WriteLine($"Nombre de jugador [{i + 1}]: {goleador_actual[i]} ");

            // Busqueda binaria

            string clave;
            while (true) {
                Console.Write("\nDigite clave a buscar '*' para salir:");
                clave = Console.ReadLine();
                if (clave == "*") break;

                int izq = 0, der = goleador_actual.Length - 1, mit = (izq + der) / 2;
                while (goleador_actual[mit] != clave && izq <= der) {
                    if (clave.CompareTo(goleador_actual[mit]) > 0)
                        izq = mit + 1;
                    else
                        der = mit - 1;
                    mit = (izq + der) / 2;
                }

                // Busqueda secuencial
                bool band = false;
                for (int i = 0; i < goleador_anterior.Length && band == false; i++){
                    if (goleador_anterior[i] == clave)
                        band = true;
                }
                if (clave == goleador_actual[mit] || band == true)
                    Console.WriteLine($"\nJugador puede ser seleccionado");
                else
                    Console.WriteLine($"\nJugador no puede ser seleccionado");
            }
        }
    }
}

