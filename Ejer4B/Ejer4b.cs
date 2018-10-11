using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4B
{
    class Ejer4b
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Debes introducir como argumentos un simbolo (+-*/) y los numeros que quieras operar");
            }
            else
            {
                try
                {
                    Ejer4b ejer = new Ejer4b();
                    char simbolo = Convert.ToChar(args[0]);
                    int[] numeros = new int[args.Length - 1];
                    for (int i = 1; i < args.Length; i++)
                    {
                        numeros[i - 1] = Convert.ToInt32(args[i]);
                    }

                Console.WriteLine(ejer.Calculo(simbolo, numeros));
                } catch (FormatException)
                {
                    Console.WriteLine("Error al introducir los algumentos, deben estar separados y no pueden ser letras");
                }
            }
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
                                Console.WriteLine("No se peude dividir entre 0");
                                return 0;
                            }
                            resultado /= parametros[i];
                        }
                        break;
                    default:
                        Console.WriteLine("Debes introducir un simbolo valido");
                        break;
                }
            }
            return resultado;
        }
    }
}
