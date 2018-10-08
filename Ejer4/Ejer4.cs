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
            Console.WriteLine((int)ejer.calculo('+', "2346"));
            Console.ReadKey();
        }


        public double calculo(char simbolo, String numeros)
        {
            double resultado = -1;
            switch (simbolo)
            {
                case '+':
                    resultado = 0;
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        Console.WriteLine(numeros[i]);
                        resultado =resultado+(double)numeros[i];
                        Console.WriteLine("result: " +resultado);
                        
                    }
                    break;
                case '-':
                    break;
                case '*':
                    break;
                case '/':
                    break;
                default:
                    break;
            }

            return resultado;
        }
    }
}
