using System;

/*-Se pide crear un programa en C# que implemente los conceptos de arreglos unidimensionales. Llenar un arreglo con N notas 
 * de los estudiantes del curso e imprimir:
Nota promedio.
Nota mayor y nota menor.
Cantidad y porcentaje de notas mayores o iguales a 3.0.
Cantidad y porcentaje de notas inferiores a 3.0.
Imprimir las notas mayores al promedio.
Imprimir el arreglo de forma ascendente.
Leer una nota y buscarla en el arreglo, en caso de existir imprimir su posición; sino imprimir que la nota no existe.
 * */
namespace Arreglos_Estudiantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double suma = 0;
            int contMay = 0, contMen = 0; // Contadores inicializados en 0
            double men = 5.0, may = 0; // La nota menor se inicializa en la mayor, y la mayor se inicializa con la menor
            Console.Write("Digite la cantidad de estudiantes: ");
            n = Convert.ToInt32(Console.ReadLine());
            double[] notas = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite la nota del alumno [{i + 1}] = ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                suma += notas[i]; // Suma de todas las notas
                if (notas[i] > may)
                    may = notas[i]; // busqueda de la nota mayor
                else if (notas[i] < men)
                    men = notas[i]; // busqueda de la nota menor
                if (notas[i] >= 3.0) 
                    contMay++; // Contador de notas mayores
                else
                    contMen++; // Contador de notas menores
            } 
            Console.WriteLine($"\nLa nota promedio es :               {(double)suma / n:F2}"); // Calculo del promedio de notas
            Console.WriteLine($"La nota mayor es :                  {may}");
            Console.WriteLine($"La nota menor es :                  {men}");
            Console.WriteLine($"Cantidad de nota mayores :          {contMay}");
            Console.WriteLine($"Cantidad de notas menor:            {contMen}");
            Console.WriteLine($"Porcentaje de notas mayores:        {(double)contMay/n:P2}"); // Porcentaje de notas mayores
            Console.WriteLine($"Porcentaje de notas menores:        {(double)contMen/n:P2}"); // Porcentaje de notas menores
            Console.Write($"Las notas mayores al promedio son: ");

            for (int i = 0; i < n; i++)
            {
                if (notas[i] > suma / n) // Calcular notas mayores al promedio
                    Console.Write($" {notas[i]} "); 
            }
            // Metodo de ordenamiento ascendente por burbuja
            for (int i = 0; i < notas.Length - 1; i++){
                for (int j = 0; j < notas.Length - 1; j++){
                    if (notas[j] > notas[j+1])
                    { 
                        double aux = notas[j];
                        notas[j] = notas[j+1];
                        notas[j+1] = aux;
                    }
                }
            }
            Console.WriteLine($"\n\nNOTAS ORDENADO DE FORMA ASCENDENTE");
            for (int i = 0; i < n; i++){
                Console.WriteLine($" Notas[{i+1}] = {notas[i]}");
            }
            // Metodo de busqueda secuencial optimizado
            Console.WriteLine("Ingrese la nota que desea buscar: ");
            double clave = Convert.ToDouble(Console.ReadLine());
            int pos = -1;
            for (int i = 0; i < notas.Length; i++){
                if (notas[i] == clave)
                {
                    pos = i;
                    break;
                }
            }
            if (pos != -1)
                Console.WriteLine($"\nNota existe en posicion:              {pos + 1}");
            else
                Console.WriteLine($"\nNota no existe");
        }
    } 
}




