using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4
{
    class Ejer4
    {
        static void Main(string[] args)
        {
            Ejer4 ejer = new Ejer4();


            Console.WriteLine("Suma: " + ejer.Calculo('+', 2, 3, 4));
            Console.WriteLine("Resta: " + ejer.Calculo('-', 2, 3, 4));
            Console.WriteLine("Multiplicacion: " + ejer.Calculo('*', 2, 3, 4));
            Console.WriteLine("Multiplicacion sin valores: " + ejer.Calculo('*'));

            double valorDivision = ejer.Calculo('/', 2, 3, 4,0);
            if (valorDivision == 0)
            {
                Console.WriteLine("No se puede dividir entre 0");
            }
            else
            {
                Console.WriteLine("Division: " + valorDivision);
            }
            valorDivision = ejer.Calculo('/', 2, 3, 4);
            if (valorDivision == 0)
            {
                Console.WriteLine("No se puede dividir entre 0");
            }
            else
            {
                Console.WriteLine("Division: " + valorDivision);
            }

            Console.WriteLine("\nNo calculo sin simbolo " + ejer.Calculo('3', 2, 3, 4));
            Console.ReadKey();
        }


        public double Calculo(char simbolo, params int[] parametros)
        {
            double resultado = 0;
            if (parametros.Length != 0)
            {
                switch (simbolo)
                {
                    case '+':
                        resultado = parametros[0];
                        for (int i = 1; i < parametros.Length; i++)
                        {
                            resultado += parametros[i];
                        }
                        break;
                    case '-':
                        resultado = parametros[0];
                        for (int i = 1; i < parametros.Length; i++)
                        {
                            resultado -= parametros[i];
                        }
                        break;
                    case '*':
                        resultado = parametros[0];
                        for (int i = 1; i < parametros.Length; i++)
                        {
                            resultado = resultado * parametros[i];
                        }
                        break;
                    case '/':
                        resultado = parametros[0];
                        for (int i = 1; i < parametros.Length; i++)
                        {
                            if (parametros[i] == 0)
                            {
                                return 0;
                            }
                            resultado /= parametros[i];
                        }
                        break;
                    default:
                        break;
                }
            }

            return resultado;
        }
    }
}
