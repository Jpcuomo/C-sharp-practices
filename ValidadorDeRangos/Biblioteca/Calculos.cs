using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase que maneja el cálculo de mínimos y máximos
    /// </summary>
    public class Calculos
    {
        /// <summary>
        /// Busca al valor minimo ingresado
        /// </summary>
        /// <param name="numero">Numero ingresado por usuario</param>
        /// <param name="contador">contador recibido como parámetro</param>
        /// <param name="min">Menor número posible pasado como parámetro</param>
        /// <returns>Valor mínimo</returns>
        public static int BuscarMinimo(int numero, int contador, int min)
        {
            if (contador == 0)
            {
                min = numero;
            }
            else
            {
                if (numero < min)
                {
                    min = numero;
                }
            }

            return min;
        }

        /// <summary>
        /// Busca al valor máximo ingresado
        /// </summary>
        /// <param name="numero">Numero ingresado por usuario</param>
        /// <param name="contador">contador recibido como parámetro</param>
        /// <param name="max">Mayor número posible pasado como parámetro</param>
        /// <returns>Valor máximo</returns>
        public static int BuscarMaximo(int numero, int contador, int max)
        {
            if (contador == 0)
            {
                max = numero;
            }
            else
            {
                if (numero > max)
                {
                    max = numero;
                }
            }

            return max;
        }

        public static double CalcularPromedio(int acumulador, int contador)
        {
            double promedio = (double)acumulador / contador;
            return promedio;
        }
    }
}