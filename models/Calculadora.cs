using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace trabalhodotnet.models
{
    public class Calculadora
    {

        
        public int Somar(int num1,int num2)
        {
            int resultado = num1 + num2;
             return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
             return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
             return resultado;
        }

        public int Dividir(int num1, int num2)
        {

            if (num1 == 0 || num2 == 0)
            {
                 Console.WriteLine("a divisão por zero não existe");
                 
            }


            // if (num1 < num2)
            // {
            //     int resto = num1 % num2;
            //     Console.WriteLine($"na divisão em programação, retornam-se valores inteiros. o valor do resto da divisão é: {resto}\n\n\n");
                
            // }

            if (num1 > num2)
            {
                int resultado = num1 / num2;
            }

            return 0;
        }



    }
}
