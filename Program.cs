using System;

namespace BasicCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Básica");
            Console.WriteLine("--------------------");

            while (true)
            {
                Console.WriteLine("Selecione uma operação:");
                Console.WriteLine("[1]. SOMA");
                Console.WriteLine("[2]. SUBTRAÇÃO");
                Console.WriteLine("[3]. MULTIPLICAÇÃO");
                Console.WriteLine("[4]. DIVISÃO");
                Console.WriteLine("[0]. SAIR");

                Console.Write("Opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 0)
                    break;

                Console.Write("Digite o primeiro número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case 1:
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        break;
                    case 3:
                        resultado = num1 * num2;
                        break;
                    case 4:
                        if (num2 != 0)
                            resultado = num1 / num2;
                        else
                            Console.WriteLine("Erro: Divisão por zero!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("Resultado: " + resultado);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("Obrigado por usar a Calculadora!");
        }
    }
}
