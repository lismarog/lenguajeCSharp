using System;
namespace Examen_Metodos
{
    internal class Program
    {
        const int MULTIPLICACION_FILAS_COLUMNAS = 120;
        static void Main()
        {

            Console.WriteLine("                                        -----> REGISTRO DE VENTAS <-----                 ");
            Console.WriteLine("\n");
            Console.WriteLine("\tMedellín \t\tBogota \t\tCali \t\tBarranquilla \t\tCartagena  \tPasto ");
            int[,] matriz = new int[20, 6];
            LlenarMatriz(matriz);
            ImprimirMatriz(matriz);
            Console.WriteLine("\n\n");
            Console.Clear();
            Console.WriteLine("                                        -----> REPORTE DE VENTAS <-----                 ");
            // Punto 1
            Console.WriteLine("\n");
            double sumTotal = SumaEmpresas(matriz);
            Console.WriteLine($" La suma de todas las empresas es:   {sumTotal:C2}");
            //Punto 2
            PromedioVentas(sumTotal, "Promedio");
            //Punto 3
            CantidadVentas(matriz, sumTotal, " Cantidad");
            //Punto 4
            CantidadVentasInferioresPromedio(matriz, sumTotal, "cantidad");
            //Punto 5
            CantidadVentasIguales(matriz, "cantidad");
            //Punto 6
            MayorVenta(matriz, "elemento mayor");
            // Punto 7
            MenorVenta(matriz, "elemento menor");
            //Punto 8
            BusquedaVenta(matriz);
            Console.Clear();
            Console.WriteLine("                                        -----> REPORTE DE VENTAS <-----                 ");
            //Punto 9
            CantidadVentasMayores(matriz, "Cantidad");
            //Punto 10
            VentaPrimerasCiudades(matriz, " Cantidad");
            //Punto 11
            VentasSuperiorMillonEnMedCalCar(matriz, "Cantidad de ventas superiores");
            //Punto 12
            VentaTotalUltEmpresas(matriz, "Venta total");
            //Punto 13
            PromedioVentas4Ciudades(matriz, "Promedio");
            //Punto 14
            VentaTotalPrimyUlt(matriz, "Venta total");
            //Punto 15
            VentaMayorRealizadaMedellin(matriz, "Venta mayor");
            //Punto 16
            VentaMenorEmpresaPar(matriz, "Venta menor");
            //Punto 17
            PorcentajeVentasPrimCiudades(matriz, "Porcentaje ventas", sumTotal);
            //Punto 18
            PorcentajeVentasInf(matriz, "Porcentaje ventas");
            //Punto 19
            VentaTotalCosta(matriz, "Venta");
            //Punto 20
            PorcentajeVentasCiudades(matriz, "Porcentaje ventas");
            //Punto 21
            PromedioDeEmpresas(matriz, "Venta promedio");
            //Punto 22
            VentaTotalPasto(matriz, "Venta total de");
            //Punto 23
            CantVentasMultiplo(matriz, "Cantidad de");

            Console.WriteLine("\n");
        }

        private static void LlenarMatriz(int[,] ventas)
        {
            ventas[0, 0] = 3818000; ventas[0, 1] = 1149000; ventas[0, 2] = 3615000; ventas[0, 3] = 1394000; ventas[0, 4] = 948000; ventas[0, 5] = 3734000;
            ventas[1, 0] = 0; ventas[1, 1] = 3803000; ventas[1, 2] = 3584000; ventas[1, 3] = 2483000; ventas[1, 4] = 4281000; ventas[1, 5] = 4724000;
            ventas[2, 0] = 797000; ventas[2, 1] = 2644000; ventas[2, 2] = 4822000; ventas[2, 3] = 1086000; ventas[2, 4] = 4420000; ventas[2, 5] = 385000;
            ventas[3, 0] = 431000; ventas[3, 1] = 160000; ventas[3, 2] = 2632000; ventas[3, 3] = 1549000; ventas[3, 4] = 0; ventas[3, 5] = 4215000;
            ventas[4, 0] = 3988000; ventas[4, 1] = 0; ventas[4, 2] = 2815000; ventas[4, 3] = 2179000; ventas[4, 4] = 2836000; ventas[4, 5] = 1056000;
            ventas[5, 0] = 2645000; ventas[5, 1] = 250000; ventas[5, 2] = 326000; ventas[5, 3] = 4370000; ventas[5, 4] = 4056000; ventas[5, 5] = 3164000;
            ventas[6, 0] = 817000; ventas[6, 1] = 1771000; ventas[6, 2] = 4505000; ventas[6, 3] = 1044000; ventas[6, 4] = 248000; ventas[6, 5] = 0;
            ventas[7, 0] = 1132000; ventas[7, 1] = 1133000; ventas[7, 2] = 1276000; ventas[7, 3] = 327000; ventas[7, 4] = 2399000; ventas[7, 5] = 3210000;
            ventas[8, 0] = 210000; ventas[8, 1] = 3138000; ventas[8, 2] = 614000; ventas[8, 3] = 2189000; ventas[8, 4] = 4827000; ventas[8, 5] = 1953000;
            ventas[9, 0] = 3138000; ventas[9, 1] = 792000; ventas[9, 2] = 4871000; ventas[9, 3] = 0; ventas[9, 4] = 2170000; ventas[9, 5] = 4725000;
            ventas[10, 0] = 4044000; ventas[10, 1] = 3887000; ventas[10, 2] = 2727000; ventas[10, 3] = 1622000; ventas[10, 4] = 2851000; ventas[10, 5] = 553000;
            ventas[11, 0] = 1311000; ventas[11, 1] = 0; ventas[11, 2] = 2097000; ventas[11, 3] = 3752000; ventas[11, 4] = 3525000; ventas[11, 5] = 4043000;
            ventas[12, 0] = 3009000; ventas[12, 1] = 2129000; ventas[12, 2] = 3547000; ventas[12, 3] = 2383000; ventas[12, 4] = 2277000; ventas[12, 5] = 3506000;
            ventas[13, 0] = 833000; ventas[13, 1] = 2501000; ventas[13, 2] = 893000; ventas[13, 3] = 3158000; ventas[13, 4] = 4559000; ventas[13, 5] = 381000;
            ventas[14, 0] = 1027000; ventas[14, 1] = 600000; ventas[14, 2] = 3902000; ventas[14, 3] = 2627000; ventas[14, 4] = 1856000; ventas[14, 5] = 3900000;
            ventas[15, 0] = 0; ventas[15, 1] = 1185000; ventas[15, 2] = 1584000; ventas[15, 3] = 716000; ventas[15, 4] = 0; ventas[15, 5] = 1807000;
            ventas[16, 0] = 2120000; ventas[16, 1] = 3733000; ventas[16, 2] = 3993000; ventas[16, 3] = 4167000; ventas[16, 4] = 1653000; ventas[16, 5] = 2197000;
            ventas[17, 0] = 1899000; ventas[17, 1] = 2389000; ventas[17, 2] = 3065000; ventas[17, 3] = 2074000; ventas[17, 4] = 3063000; ventas[17, 5] = 0;
            ventas[18, 0] = 4793000; ventas[18, 1] = 209000; ventas[18, 2] = 0; ventas[18, 3] = 1255000; ventas[18, 4] = 2555000; ventas[18, 5] = 4935000;
            ventas[19, 0] = 4649000; ventas[19, 1] = 1441000; ventas[19, 2] = 3414000; ventas[19, 3] = 957000; ventas[19, 4] = 4484000; ventas[19, 5] = 509000;
        }
        private static void ImprimirMatriz(int[,] matriz)
        {

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write($"           {matriz[i, j]} ");
                Console.WriteLine("     ");
            }
        }
        private static double SumaEmpresas(int[,] matriz)
        {
            double suma = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 6; j++)
                    suma += matriz[i, j];
            }
            return suma;
        }
        private static void PromedioVentas(double suma, string mensaje)
        {
            Console.WriteLine($"\n Resultado de {mensaje}:               {(double)suma / MULTIPLICACION_FILAS_COLUMNAS:C2}");
        }
        private static void CantidadVentas(int[,] matriz, double suma, string mensaje)
        {
            int cont = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 6; j++)
                    if (matriz[i, j] > suma / MULTIPLICACION_FILAS_COLUMNAS)
                        cont++;
            }
            Console.WriteLine($"\n{mensaje} de ventas >  al promedio:                {cont}");
        }
        private static void CantidadVentasInferioresPromedio(int[,] matriz, double suma, string mensaje)
        {
            int cont = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 6; j++)
                    if (matriz[i, j] <= suma / MULTIPLICACION_FILAS_COLUMNAS)
                        cont++;
            }
            Console.WriteLine($"\n La {mensaje} de ventas <= al promedio:             {cont}");
        }
        private static void CantidadVentasIguales(int[,] matriz, string mensaje)
        {
            int cont = 0;
            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 6; j++)
                    if (matriz[i, j] == 0)
                        cont++;
            Console.WriteLine($"\n La {mensaje} de ventas = 0:                        {cont}");
        }
        private static void MayorVenta(int[,] matriz, string mensaje)
        {
            int may = matriz[0, 0];
            int posi = 0;
            int posj = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (matriz[i, j] > may)
                    {
                        may = matriz[i, j];
                        posi = i;
                        posj = j;
                    }
                }
            }
            Console.WriteLine($"\n El {mensaje} : {may:C2} y se encuentra en la fila [{posi}] en la columna [{posj}]");
        }
        private static void MenorVenta(int[,] matriz, string mensaje)
        {
            int posi = 0;
            int posj = 0;
            int men = matriz[0, 0];
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (matriz[i, j] != 0)
                    {
                        if (matriz[i, j] < men)
                        {
                            men = matriz[i, j];
                            posi = i;
                            posj = j;
                        }
                    }
                }
            }
            Console.WriteLine($"\n El {mensaje} es: {men:C2} y se encuentra en la fila [{posi}] en la columna  [{posj}]\n");
        }
        private static void BusquedaVenta(int[,] matriz)
        {
            while (true)
            {
                Console.Write("\n Ingrese la clave a buscar o -1: ");
                double clave = Convert.ToDouble(Console.ReadLine());
                if (clave == -1) break;
                bool band = false;
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 6; j++)
                        if (matriz[i, j] == clave)
                            band = true; break;
                }
                if (band == true)
                    Console.WriteLine($" Una de las empresa tiene una venta con ese valor exacto\n");
                else
                    Console.WriteLine($"\n Ninguna empresa  tiene una venta con ese valor exacto\n");
            }
        }
        private static void CantidadVentasMayores(int[,] matriz, string mensaje)
        {
            int cont = 0;
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 6; j++)
                    if (matriz[i, j] >= 500000 && matriz[i, j] < 1000000)
                        cont++;
            Console.WriteLine($"\n {mensaje} de ventas entre $500.000 y $1.000.000 en las primeras 10 empresas:                            {cont}");
        }
        private static void VentaPrimerasCiudades(int[,] matriz, string mensaje)
        {
            int suma = 0;
            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 4; j++)
                    suma += matriz[i, j];
            Console.WriteLine($"\n{mensaje} de todas las ventas en las primeras 4 empresas:                                  {suma:C2}");
        }
        private static void VentasSuperiorMillonEnMedCalCar(int[,] matriz, string mensaje)
        {
            int cont = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 5; j += 2)
                    if (matriz[i, j] > 1000000)
                        cont++;
            }
            Console.WriteLine($"\n {mensaje}a $1.000.000 en las ciudades Medellín, Cali y Cartagena:                  {cont}");
        }
        private static void VentaTotalUltEmpresas(int[,] matriz, string mensaje)
        {
            int suma = 0;
            for (int i = 10; i < 20; i++)
                for (int j = 0; j < 6; j++)
                    suma += matriz[i, j];
            Console.WriteLine($"\n {mensaje} de las 10 últimas empresas:                                                  {suma:C2}");
        }
        private static void PromedioVentas4Ciudades(int[,] matriz, string mensaje)
        {
            double suma = 0;
            int cont = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    suma += matriz[i, j];
                    cont++;
                }
            }
            Console.WriteLine($"\n {mensaje} de las 4 primeras empresas:                                                      {(double)suma / cont:C2}");
        }
        private static void VentaTotalPrimyUlt(int[,] matriz, string mensaje)
        {
            double suma = 0;
            for (int i = 0; i < 20; i += 19)
                for (int j = 0; j < 6; j++)
                    suma += matriz[i, j];
            Console.WriteLine($"\n {mensaje} de la primera y la última empresa:                                           {suma:C2}");
        }
        private static void VentaMayorRealizadaMedellin(int[,] matriz, string mensaje)
        {
            int may = matriz[0, 0];
            for (int i = 1; i < 20; i++)
                if (matriz[i, 0] > may)
                    may = matriz[i, 0];
            Console.WriteLine($"\n {mensaje} realizada en Medellín:                                                       {may:C2}");
        }
        private static void VentaMenorEmpresaPar(int[,] matriz, string mensaje)
        {
            int men = matriz[0, 0];
            for (int i = 0; i < 20; i += 2)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (matriz[i, j] != 0)
                    {
                        if (matriz[i, j] < men)
                            men = matriz[i, j];
                    }
                }
            }
            Console.WriteLine($"\n {mensaje} diferente de 0 de las empresas pares:                                          {men:C2}");
        }
        private static void PorcentajeVentasPrimCiudades(int[,] matriz, string mensaje, double sumTotal)
        {
            int suma = 0;
            for (int i = 0; i < 4; i++)
                for (int j = 3; j < 6; j++)
                    suma += matriz[i, j];
            Console.WriteLine($"\n {mensaje} primeras 4 empresas últimas 3 ciudades:                                      {(double)suma / sumTotal:p}");
        }
        private static void PorcentajeVentasInf(int[,] matriz, string mensaje)
        {
            int cont = 0;
            for (int i = 3; i < 16; i += 3)
                for (int j = 0; j < 2; j++)
                    if (matriz[i, j] < 500000)
                        cont++;
            Console.WriteLine($"\n {mensaje} < $500.000 en empresas 3-6-9-12 y 15 en Medellín y Bogotá:                   {(double)cont / 10:p}");
        }
        private static void VentaTotalCosta(int[,] matriz, string mensaje)
        {
            int suma = 0;
            for (int i = 0; i < 20; i++)
                for (int j = 3; j < 5; j++)
                    suma += matriz[i, j];
            Console.WriteLine($"\n {mensaje} realizada en la costa:                                                             {suma:C2}");
        }
        private static void PorcentajeVentasCiudades(int[,]matriz, string mensaje)
        {
           int cont = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j == 2)
                        j = 4;
                    if (matriz[i, j] <= 3000000)
                        cont++;
                }
            }
            Console.WriteLine($"\n {mensaje} <= $3.000.000 en Medellín, Bogotá, Cartagena y Pasto:                        {(double)cont / 80:p}");

        }
        private static void PromedioDeEmpresas(int[,] matriz, string mensaje)
        {
            int suma = 0;
            for (int i = 0; i < 6; i++)
                suma += matriz[i, i];
            Console.WriteLine($"\n {mensaje}  en Medellín, Bogotá, Cali, Barranquilla, Cartagena y Pasto:               {(double)suma / 6:C2}");
        }
        private static void VentaTotalPasto(int[,] matriz, string mensaje)
        {
            int suma = 0;
            for (int i = 0; i < 10; i++)
                suma += matriz[i, 5];
            for (int i = 10; i < 20; i++)
                suma += matriz[i, 4];
            Console.WriteLine($"\n {mensaje} Pasto en las primeras 10 empresas y de Cartagena en las siguientes 10 empresas: {suma:C2}");
        }
        private static void CantVentasMultiplo  (int[,] matriz, string mensaje)
        {
            int cont = 0;
            for (int j = 0; j < 6; j++)
                if (matriz[14, j] % 100000 == 0)
                    cont++;
            Console.WriteLine($"\n {mensaje} de ventas múltiplos de 100.000 en la Empresa 14:                                         {cont}");
        }
    }
}

