using System;

/*1-	Pedir el ID de cada participante y llenar el arreglo de respuestas correctas con números aleatorios entre 0 y 90.
2-	Calcular el arreglo de respuestas incorrectas y crear un arreglo llamado RESULTADO con los dos arreglos anteriores,
teniendo en cuenta que las respuestas correctas dan 50 puntos y las respuestas incorrectas -30 puntos.
3-	Imprimir la información de los arreglos de forma simultánea. 
4-	Imprimir la mayor cantidad de respuestas correctas y su posición (si hay varios imprimir el último).
5-	Imprimir la menor cantidad de respuestas incorrectas y su posición (si hay varios imprimir el último)
6-	Imprimir el total acumulado por todos los resultados y el resultado promedio de la competencia.
7-	Imprimir el porcentaje de resultados mayor al promedio y el porcentaje de los menores o iguales al promedio.
8-	Permitir leer el ID de un participante y mostrar el número de respuestas correctas, el número de respuestas incorrectas y el 
resultado obtenido usando el método de búsqueda binaria (ordenar por método de burbuja optimizada).
9-	Imprimir los ID de los 3 ganadores de la prueba. (Ordenar de forma descendente el arreglo de resultados.
Recuerde que debe intercambiar también los ID. No es necesario intercambiar los otros arreglos). Usar el método de baraja.
10-	Implementar y mostrar una captura de excepción (try/catch) ingresando un valor negativo en N.
 * 
 * */

namespace ExamenArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try //  Implementacion de excepciones
            {
                //Declaración de vectores enteros de N posiciones.
                Console.Write("Ingrese la cantidad de personas que realizan el examen [N]: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\n");
                Console.Clear();
                // Declaracion de vectores
                string[] ID = new string[n];
                int[] resp_correctas = new int[n];
                int[] resp_inccorrectas = new int[n];
                int[] resultado = new int[n];
                int aux, aux1, pos = 0, pos1 = 0, acum = 0, contG = 0, contP = 0;
                double may = resp_correctas[0], men = 90;
                Random r = new Random();
                for (int i = 0; i < ID.Length; i++)
                {
                    Console.Write("Ingrese el ID de la persona: ");
                    ID[i] = Console.ReadLine();
                }
                Console.Clear();
                // Llenar vector respuestas correctas con num aleatorios
                for (int i = 0; i < resp_correctas.Length; i++)
                    resp_correctas[i] = r.Next(0, 91);
                // Llenar vector respuestas incorrectas
                for (int i = 0; i < resp_inccorrectas.Length; i++)
                    resp_inccorrectas[i] = 100 - resp_correctas[i];
                // Llenar vector resultado
                for (int i = 0; i < resultado.Length; i++)
                {
                    aux = resp_correctas[i] * 50;
                    aux1 = resp_inccorrectas[i] * (-30);
                    resultado[i] = aux + aux1;
                    acum += resultado[i];
                }
                // Imprimir vectores 
                Console.WriteLine("ID    \t  CORRECTAS \t INCORRECTAS \t     RESULTADO");
                for (int i = 0; i < resultado.Length; i++)
                    Console.WriteLine($"{ID[i]} \t\t{resp_correctas[i]} \t\t{resp_inccorrectas[i]} \t\t{resultado[i]} ");
                // Calcular posicion y mayor de vectores correctos
                for (int i = 0; i < resp_correctas.Length; i++)
                {
                    if (resp_correctas[i] > may)
                    {
                        may = resp_correctas[i];
                        pos = i;
                    }
                }
                // Calcular posicion y menor vector incorrecto
                for (int i = 0; i < resp_inccorrectas.Length; i++)
                {
                    if (resp_inccorrectas[i] < men)
                    {
                        men = resp_inccorrectas[i];
                        pos1 = i;
                    }
                }
                //Calcular porcentaje
                for (int i = 0; i < resultado.Length; i++)
                {
                    if (resultado[i] >= acum / resultado.Length)
                        contG++;
                    else
                        contP++;
                }
                Console.WriteLine($"\n");
                Console.WriteLine($"El numero mayor en respuestas correctas es:  {may}. Y su posicion es {pos + 1}.");
                Console.WriteLine($"El numero menor en respuestas incorrectas es: {men}. Y su posicion es {pos1 + 1}.\n");
                Console.WriteLine($"Acumulador de todos los resultados:     {acum}.");
                Console.WriteLine($"Resultado promedio:                     {(double)acum / resultado.Length:F2}.");
                Console.WriteLine($"Porcentaje > Promedio:                  {(double)contG / resultado.Length:P2}.");
                Console.WriteLine($"Porcentaje < Promedio:                  {(double)contP / resultado.Length:P2}.");
                // Metodo de ordenamiento de burbuja optimizado ID,Respuestas incorrectas y respuestas correctas
                bool band = true;
                int j, aux2, auxiliar1;
                string auxiliar;
                for (int i = 0; i < ID.Length && band; i++)
                {
                    band = false;
                    for (j = 0; j < ID.Length - i - 1; j++)
                    {
                        if (ID[j].CompareTo(ID[j + 1]) > 0)
                        {
                            auxiliar = ID[j];
                            ID[j] = ID[j + 1];
                            ID[j + 1] = auxiliar;
                            band = true;
                            auxiliar1 = resp_correctas[j];
                            resp_correctas[j] = resp_correctas[j + 1];
                            resp_correctas[j + 1] = auxiliar1;
                            band = true;
                            aux2 = resp_inccorrectas[j];
                            resp_inccorrectas[j] = resp_inccorrectas[j + 1];
                            resp_inccorrectas[j + 1] = aux2;
                            band = true;
                        }
                    }
                }
                //Método de búsqueda binaria
                string clave;
                while (true)
                {
                    Console.Write("\nDigite el ID a buscar '*' para salir: ");
                    clave = Console.ReadLine();
                    if (clave == "*") break;
                    int izq = 0, der = ID.Length - 1, mit = (izq + der) / 2;
                    while (ID[mit] != clave && izq <= der)
                    {
                        if (clave.CompareTo(ID[mit]) > 0)
                            izq = mit + 1;
                        else
                            der = mit - 1;
                        mit = (izq + der) / 2;
                    }
                    if (clave == ID[mit])
                    {
                        Console.WriteLine($"\n");
                        Console.WriteLine("CORRECTAS \t   INCORRECTAS \t \t     RESULTADO");
                        Console.WriteLine($"{resp_correctas[mit]}    \t\t\t{resp_inccorrectas[mit]}  \t\t\t{resultado[mit]}");
                    }
                    else
                        Console.WriteLine($"\nID no encontrado");
                }
                Console.Clear();
                // Metodo de ordenamiento baraja
                for (int i = 0; i < resultado.Length; i++)
                {
                    aux = resultado[i];
                    for (j = i - 1; j >= 0 && resultado[j] < aux; j--)
                        resultado[j + 1] = resultado[j];
                    
                    resultado[j + 1] = aux;
                }
                // Imprimir vector respuestas incorrectas descendente 
                Console.WriteLine("\nVECTOR RESPUESTAS ORDENADO DE MANERA DESCENDENTE \n");
                for (int i = 0; i < resultado.Length; i++)
                    Console.WriteLine($" [{i + 1}] = {resultado[i]} ");

                Console.WriteLine("\nLAS 3 NOTAS MAS ALTAS\n");
                for (int i = 0; i < 3; i++)
                    Console.WriteLine($"Nota mas alta [{i + 1}] = {resultado[i]} ");
                Console.WriteLine($"\n");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Error: Por favor no superar el tamaño de un número entero {Int32.MaxValue}");
            }
        }
    }
}


