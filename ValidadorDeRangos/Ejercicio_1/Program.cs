using Biblioteca;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio1
{
    internal class Program
    {
        static int max = 100;
        static int min = -100;
        static int contador = 0;
        static int acumulador = 0;
        static int valorMinimo = int.MaxValue; // Inicializa con un valor máximo posible
        static int valorMaximo = int.MinValue; // Inicializa con un valor mínimo posible

        static void Main()
        {
            while (contador < 10)
            {
                int? valor = Validador.ParsearStringIngresado();
                if (valor.HasValue && Validador.ValidarRango(valor.Value, min, max))
                {
                    valorMinimo = Calculos.BuscarMinimo(valor.Value, contador, valorMinimo);
                    valorMaximo = Calculos.BuscarMaximo(valor.Value, contador, valorMaximo);
                    acumulador += valor.Value;
                    contador++;
                }
                else
                {
                    Console.WriteLine("Número incorrecto o fuera de rango");
                }
            }
            // Muestra los resultados después del bucle
            Console.WriteLine($"Valor mínimo: {valorMinimo}");
            Console.WriteLine($"Valor máximo: {valorMaximo}");
            Console.WriteLine($"Promedio de números ingresados {Calculos.CalcularPromedio(acumulador, contador):N2}");
        }
    }
}