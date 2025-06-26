using System;

namespace Examen_Estructura_de_Datos_l
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            int[] diaspormes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.WriteLine("Meses y dias por mes");
            for (int i = 0; i < meses.Length; i++)
            {
                Console.WriteLine($"{meses[i]}: {diaspormes[i]} días");

            }

            Console.WriteLine("\nIngrese el número de dia del año (1-365): ");

            var diaDelAño = Convert.ToInt32(Console.ReadLine());

            if (!int.TryParse(Console.ReadLine(), out diaDelAño) || diaDelAño < 1 || diaDelAño > 365)
            {
                Console.WriteLine("Número de día inválido. Debe estar entre 1 y 365.");
                return;
            }

            int mesActual = 0;
            while (diaDelAño > diaspormes[mesActual])
            {
                diaDelAño -= diaspormes[mesActual];
                mesActual++;
            }
            Console.WriteLine($"El día {diaDelAño} del año corresponde al mes de {meses[mesActual]}.");
        }
    }
}
