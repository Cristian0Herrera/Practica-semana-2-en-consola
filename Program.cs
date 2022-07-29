using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_semana_2_en_consola
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

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Mostrar el título como la aplicación calculadora de consola de C#.
            Console.WriteLine("Calculadora de consola en C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                // Declare variables y establezca en vacío.
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // Pida al usuario que escriba el primer número.
                Console.Write("Escriba un número y, a continuación, presione Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Esta no es una entrada válida. Introduzca un valor entero ");
                    numInput1 = Console.ReadLine();
                }

                // Pida al usuario que escriba el segundo número.
                Console.Write("Escriba otro número y, a continuación, presione Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Esta no es una entrada válida. Introduzca un valor entero: ");
                    numInput2 = Console.ReadLine();
                }

                // Pida al usuario que elija un operador.
                Console.WriteLine("Elija un operador de la lista siguiente:");
                Console.WriteLine("\ta - Sumar");
                Console.WriteLine("\ts - Restar");
                Console.WriteLine("\tm - Multiplicar");
                Console.WriteLine("\td - Dividir");
                Console.Write("¿Su opción?");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Esta operación dará lugar a un error matemático.\n");
                    }
                    else Console.WriteLine("Su resultado: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! Se ha producido una excepción al intentar hacer los cálculos.\n - Detalles: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Espere a que el usuario responda antes de cerrar.
                Console.Write("Presione 'n' y Enter para cerrar la aplicación, o presione cualquier otra tecla y Enter para continuar: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Espaciado de líneas amigable,
            }
            return;
        }
    }
}