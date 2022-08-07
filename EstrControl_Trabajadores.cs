using System;

/*
 * En una empresa realizan un sorteo para entregar algunos electrodomésticos a cada uno de sus N trabajadores. 
Al llegar a lugar el sorteo, a cada trabajar se les pregunta su nombre y saca una balota de una urna (número aleatorio entre 10 y 20). 
Si esta balota es la ganadora se le pide sacar una segunda balota de otra urna con números entre 1 y 3,
la cual le permitirá ganarse un televisor si la balota es igual a 1, una lavadora si la balota es igual a 2 y un computador si 
la balota es igual a 3. 
Imprimir el nombre del trabajador y el electrodoméstico ganado en caso de ganar. Por ejemplo, 
"FELICITACIONES JAIRO ACABAS DE GANAR UN TELEVISOR", esto si fue ganador y la segunda balota igual a 1; 
si no fue afortunado, imprimir "GRACIAS POR PARTICIPAR".
 * */
namespace EstrControl_Trabajadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string nombre, premio;
                int num1, num2, num3;
                Console.Write("Digite la cantidad de trabajadores: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Random r = new Random();
                num1 = r.Next(10, 21);
                Console.WriteLine($"El numero generado es: #{num1}");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Digite su nombre: ");
                    nombre = Console.ReadLine();
                    num2 = r.Next(10, 21);
                    if (num2 == num1)
                    {
                        num3 = r.Next(1, 4);
                        if (num3 == 1)
                            premio = "Televisor";
                        else if (num3 == 2)
                            premio = "Lavadora";
                        else
                            premio = "Computador";
                        Console.WriteLine("Felicitaciones " + nombre + ". Acabas de ganar: " + premio);
                    }
                    else
                        Console.WriteLine("Gracias por participar " + nombre);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Error. Intente nuevamente");
            }
        }

    }
}
