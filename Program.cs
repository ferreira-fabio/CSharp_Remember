using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }
        static void Soma()
        {

            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            System.Console.WriteLine("");
            // System.Console.WriteLine("O Resultado da soma é: " + resultado);
            System.Console.WriteLine($"O resultado da soma é : {resultado.ToString("F2")}");
            Console.ReadKey();
            Menu();



        }
        static void Subtracao()
        {

            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            System.Console.WriteLine("");
            // System.Console.WriteLine("O Resultado da soma é: " + resultado);
            System.Console.WriteLine($"O resultado da subtracao é : {resultado}");
            Console.ReadKey();
            Menu();

        }

        static void Divisao()
        {

            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            System.Console.WriteLine("");
            // System.Console.WriteLine("O Resultado da soma é: " + resultado);
            System.Console.WriteLine($"O resultado da divisão é : {resultado.ToString("F2")}");
            Console.ReadKey();
            Menu();


        }
        static void Multiplicacao()
        {

            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            System.Console.WriteLine("");
            // System.Console.WriteLine("O Resultado da soma é: " + resultado);
            System.Console.WriteLine($"O resultado da soma é : {resultado.ToString("f2")}");
            Console.ReadKey();
            Menu();
        }

        static void Menu()
        {

            System.Console.WriteLine("Entre com o que gostaria de calcular: ");
            System.Console.WriteLine("1 - Soma");
            System.Console.WriteLine("2 - Subtração");
            System.Console.WriteLine("3 - Divisão");
            System.Console.WriteLine("4 - Multiplicação");
            System.Console.WriteLine("5 - Sair");

            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("Faça uma escolha: ");

            short decisao = short.Parse(Console.ReadLine());

            switch (decisao)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                case 5: System.Environment.Exit(0); break;
                default:
                    System.Console.WriteLine("Informe a operacao correta.");
                    Menu();
                    break;


            }



        }

    }
}