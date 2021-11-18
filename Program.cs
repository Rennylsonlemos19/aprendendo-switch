using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_somaswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado;

            Console.WriteLine("DIGITE UM NUMERO");
            double n1 = double.Parse( Console.ReadLine());

            Console.WriteLine("DIGITE UM NUMERO");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE A OPERAÇÃO:" +
                "\n+ / - *");
            string operacao = Console.ReadLine();

            switch (operacao) 
                {
                case "+":
                      resultado = n1 + n2;
                    Console.WriteLine("A SOMA DOS VALORES SERA "+ resultado);
                break;

                case "-":
                     resultado = n1 - n2;
                    Console.WriteLine("A SUBTRAÇÃO DOS VALORES SERA " + resultado);
                    break;

                case "/":
                     resultado = n1 / n2;
                    Console.WriteLine("A DIVISÃO DOS VALORES SERA "  + resultado);
                    break;

                case "*":
                     resultado = n1 * n2;
                    Console.WriteLine("A MULTIPLICAÇÃO DOS VALORES SERA " + resultado);
                    break;

                default:
                    Console.WriteLine("OPAÇÃO INVALIDA");
                    break;
            }
            Console.ReadKey();

        }
    }
}
