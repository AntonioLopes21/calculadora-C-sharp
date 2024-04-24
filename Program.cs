//métodos

using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using trabalhodotnet.models;

public class Program
{

    public static void Main(string[] args)
    {

        Console.WriteLine("Bem vindo a calculadora!");

        Calculadora Calc = new Calculadora();

        Console.WriteLine("digite o valor de um numero:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("digite o valor de um numero:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        //----------------------------------------------------------------------------------------//
        //switch case


        int i = 0;
        while (i == 0)
        {
            Console.WriteLine("agora digite o tipo de operação que deseja fazer:");
            Console.WriteLine("1- adição\n2- subtração\n3- multiplicação\n4- divisão\n5 - encerrar programa");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Você selecionou adição: ");
                    int resultado = Calc.Somar(num1, num2);
                    Console.WriteLine($"{resultado}");
                    break;

                case 2:
                    Console.WriteLine($"Você selecionou subtração: ");
                    resultado = Calc.Subtrair(num1, num2);
                    Console.WriteLine($"{resultado}");
                    break;

                case 3:
                    Console.WriteLine($"Você selecionou multiplicação: ");
                    resultado = Calc.Multiplicar(num1, num2);
                    Console.WriteLine($"{resultado}");
                    break;

                case 4:
                    Console.WriteLine("Você selecionou divisão: ");
                    resultado = Calc.Dividir(num1, num2);
                    Console.WriteLine($"{resultado}");
                    if (num1 < num2)
                    {
                        int resto = num1 % num2;
                        Console.WriteLine($"na divisão em programação, retornam-se valores inteiros. o valor do resto da divisão é: {resto}\n\n\n");
                    }
                    break;

                case 5:
                    Console.WriteLine($"Você encerrou o programa.");
                    Environment.Exit(0);

                    break;


                default:
                    Console.WriteLine("você selecionou uma opção incorreta\n\n\n");
                    break;
            }
        }


        //-----------------------------------------------------------------------------------------------------


















        // List<string> nomes = new List<string>();

        // nomes.Add("tonin");
        // nomes.Add("jiraya");
        // nomes.Add("don jobin");
        // nomes.Add("21, mas string");

        // foreach (string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }


        // Dictionary<string, int> idadePorPessoa = new Dictionary<string, int>();

        // idadePorPessoa.Add("antonio", 20);
        // idadePorPessoa.Add("leonardo", 25);
        // idadePorPessoa.Add("marcos", 46);

        // foreach (KeyValuePair<string, int> item in idadePorPessoa)
        // {
        //     Console.WriteLine($"Nome: {item.Key}, Idade: {item.Value}");
        // }











        // Pessoa p1 = new Pessoa("Luis", 21);
        // Pessoa P2 = new Pessoa("Antônio", 20);

        // P2.apresentar();
        // p1.apresentar();






        //     //arrays
        //     int[] numeros = new int[4];

        //     numeros[0] = 100;
        //     numeros[1] = 14;
        //     numeros[2] = 11;
        //     numeros[3] = 12;

        //     Console.WriteLine("elementos do array:");

        //     foreach (int num in numeros)
        //     {
        //         Console.WriteLine(num);
        //     }


        //     //array multidimensional
        //     int[,] matriz = new int [3,3];

        //     matriz[0,0] = 0;
        //     matriz[0,1] = 1;
        //     matriz[0,2] = 0;
        //     matriz[1,0] = 0;
        //     matriz[1,1] = 1;
        //     matriz[1,2] = 0;
        //     matriz[2,0] = 0;
        //     matriz[2,1] = 0;
        //     matriz[2,2] = 1;

        //     for (int i = 0; i < 3; i++)
        //     {
        //         for(int j = 0; j < 3; j++)
        //         {
        //             Console.WriteLine(matriz[i, j] + "");
        //         }
        //         Console.WriteLine();
        //     } 


        // }


        // static void Main(string[] args)
        // {
        //     Agradecimentos.MeusAgradecimentos();

        //     int resultado = MultiplicacaoDeCalculo.MultiplicacaoDeCalculos(6, 6);
        //     Console.WriteLine($"o resultado da multiplicação é : {resultado}");

        // }
    }
}


























// int num1, num2, resultado;

// Console.WriteLine("digite o primeiro valor:");
// num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("digite o Segundo valor:");
// num2 = Convert.ToInt32(Console.ReadLine());

// resultado = num1 + num2;

// Console.WriteLine($"o resultado de {num1} + {num2} é {resultado}");

























// List<string> ListaString = new List<string>();

// ListaString.Add("SP");
// ListaString.Add("BA");
// ListaString.Add("PE");
// Console.WriteLine($"PERCORRENDO A LISTA COM FOR\n");
// for(int contador = 0; contador < ListaString.Count; contador ++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {ListaString[contador]}");
// }


// Console.WriteLine($"\n\n\nPERCORRENDO A LISTA COM FOREACH");
// int contadorForeach = 0;
// foreach(string item in ListaString)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {ListaString[contadorForeach]}");
//     contadorForeach ++;
// }



