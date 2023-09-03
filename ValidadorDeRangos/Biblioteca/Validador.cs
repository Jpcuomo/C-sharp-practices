using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Biblioteca
{
    public class Validador
    {
        /// <summary>
        /// Valida si un valor está dentro de un rango especificado.
        /// </summary>
        /// <param name="valor">Valor a validar.</param>
        /// <param name="min">Mínimo valor incluido.</param>
        /// <param name="max">Máximo valor incluido.</param>
        /// <returns>True si el valor está dentro del rango, false de lo contrario.</returns>
        public static bool ValidarRango(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }

        /// <summary>
        /// Intenta parsear una cadena en un número entero. Si la conversión es exitosa, devuelve el número; de lo contrario, devuelve null.
        /// </summary>
        /// <param name="numeroString">Cadena a ser parseada.</param>
        /// <returns>Número entero parseado o null en caso de error.</returns>
        public static int? ParsearStringIngresado()
        {
            try
            {
                Console.WriteLine("Ingresá un número: ");
                int numero = int.Parse(Console.ReadLine());
                return numero;
            }
            catch (FormatException)
            {
                return null;
            }
        }
    }
}