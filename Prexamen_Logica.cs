using System;

namespace Prexamen_Logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int a = (r.Next(1, 6)) * 2, b = r.Next(-50, 51), c = r.Next(0, 6); // Generar numeros aleatorios
            double e = Math.E, pi = Math.PI; //Asignar valor constantes a una varaible
            Console.Write("Digite el valor del radio: ");
            double radio = Convert.ToDouble(Console.ReadLine()); //Leer el valor del radio
            Console.Write("Digite el valor del lado: ");
            int lado = Convert.ToInt32(Console.ReadLine()); // Leer cuantos lados hay
            double x = ((Math.Sqrt(Math.Pow(e, 3)) + Math.Pow((2 * c), 1 / 3) - Math.Pow((c + 1) * 5555.3 - b, 1 / 4))) / (4.5 * a * b + 1); ; // Calculo de operacion matematica
            double w = x * 2.5; // Aumentar el valor de la ecuación en un 250 %
            double z = x + w; // Valor total de la operacion luego de incrementar el 250%
            double volEsf = (double)4/3 * pi * Math.Pow(radio,3);
            double volCub = Math.Pow(lado, 3); // Calcular el volumen total de las dos figuras
            // Imprimir en pantalla la información 
            Console.WriteLine($"\nLos numeros aleatorios son: #a -> {a:N0} // #b -> {b:N0}  // #c -> {c:N0} ");
            Console.WriteLine($"\nEl valor constante de e:     {Math.E:N11}");
            Console.WriteLine($"El valor constante de PI:      {Math.PI:N11}");
            Console.WriteLine($"El valor de la ecuación es:    {x:N3}");
            Console.WriteLine($"El valor de w:                 {w:N3}");
            Console.WriteLine($"El valor de z:                 {z:N3}");
            Console.WriteLine($"El volumen total:              {volCub+volEsf:N3}\n");

        }
    }
}
