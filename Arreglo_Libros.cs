using System;

namespace Arreglos_Libros
{
    /*
       Diseñar una solución en C# que permita leer el serial de un libro e imprimir si puede ser prestado a un estudiante o no. 
     * En la biblioteca se tiene un vector con los seriales de los M libros que son de reserva.  
     * Usar el método de Búsqueda binaria y ordenar por el método de selección directa ascendente.
     * */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Digite la cantidad de libros: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] serial = new int[n];

            Random random = new Random();
            Console.WriteLine($"\nLos seriales de los libros son:\n");  
            for (int i = 0; i < serial.Length; i++)
            {   
                serial[i] = random.Next(1000,10000);
                Console.WriteLine($"Serial en la posicion [{i+1}] = {serial[i]} ");
            }
            // Ordenamiento por selección directa ascente
            for (int i = 0; i < serial.Length-1; i++)
            {
                for (int j =i+1 ; j < serial.Length; j++)
                {
                    if (serial[i] > serial[j]) 
                    {
                        int aux = serial[i];
                        serial[i] = serial[j];
                        serial[j] = aux;
                    }
                }

            }
            Console.WriteLine($"\n\nEL SERIAL ORDENADO DE FORMA SELECCION ASCENDENTE:\n");
            for (int i = 0; i < serial.Length; i++)
            {
                Console.WriteLine($"Serial ordenado [{i+1}] = {serial[i]} ");
            }

            //Busqueda binaria
            Console.Write("\nDigite clave a buscar: ");
            int clave = Convert.ToInt32(Console.ReadLine());
            int izq = 0, der = serial.Length - 1, mit = (izq + der) / 2;
            while (serial[mit] != clave && izq <= der)
            {
                if (clave > serial[mit])
                    izq = mit + 1;
                else
                    der = mit - 1;
                mit = (izq + der) / 2;
            }
            if (serial[mit] == clave)
                Console.WriteLine($"\n Libro con serial: {clave} no se puede prestar. Se encuentra en posicion {mit + 1}.");
            else
                Console.WriteLine($"\nLbro con serial {clave} puede ser prestado.");

        }
    }
}
