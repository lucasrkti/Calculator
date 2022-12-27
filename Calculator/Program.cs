
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
            static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação gostaria de fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Raiz Quadrada");
            Console.WriteLine("6 - Para saber o valor de PI");
            Console.WriteLine("7 - Sair");

            Console.WriteLine("------------");
            Console.WriteLine("Selecione uma opção..");
            short operacao = short.Parse(Console.ReadLine());

            switch(operacao)
            {
                case 1: Soma();
                    break;
                case 2: Subtracao(); 
                    break;  
                case 3: Multiplicacao();
                    break;
                case 4: Divisao();
                    break;
                case 5:Raiz();
                    break;
                case 6: Pi();
                    break;
                case 7: 
                    Console.WriteLine("Obrigado por utilizar a calculadora");
                    System.Environment.Exit(0); // Environment é o ambiente para sair e o parametro zero, pois 0 sign saida com sucesso
                    
                    break;
                default: Menu();
                    break;
            }

        }
            static void Soma()
            {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(""); //somente para pular linha

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é {resultado}");
            //Console.WriteLine($"O resultado da soma é { v1 + v2}");
            //Console.WriteLine("O resultado da soma é " + (v1 + v2));

            Console.ReadKey();

            Menu(); // chamando a calculadora novamente após finalizar os calculos

            }

            static void Subtracao()
            {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;

            Console.WriteLine("O resultado da subtração é " + resultado);

            Console.ReadKey(); // nao deixa o programa fechar via terminal
            
            Menu();

            }

            static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é {resultado}");

            Console.ReadKey();

            Menu();
        }

            static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Informe o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é {resultado}");

            Menu();
        }

            static void Raiz()
        {
           
            Console.Clear();
            Console.WriteLine("Informe o numero para a Raiz Quadrada: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"A Raiz Quadrada de {v1} é " + Math.Sqrt(v1));

            Menu();

            Console.ReadKey();

        }

            static void Pi()
        {
           
            Console.Clear();

            Console.WriteLine("");

            double v1 = Math.PI;

            Console.WriteLine("O valor de PI é :" + (Math.Round(v1, 2))); // exibe o PI com somente duas casas decimais

            Console.ReadKey(); //Insere uma pausa para o usuario visualizar o resultado antes de chamar o menu novamente

            Menu();
        }
    }
}