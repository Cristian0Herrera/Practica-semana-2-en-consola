using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_semana_2_en_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // El valor predeterminado es "not-a-number" que usamos si una operación, como la división, podría provocar un error.

            // Usar una instrucción switch para hacer los cálculos
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Pida al usuario que introduzca un divisor distinto de cero
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Devolver texto para una entrada de opción incorrecta
                default:
                    break;
            }
            return result;
        }
    }
        }
    }
}
