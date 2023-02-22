using System;

namespace calculadora
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

            Console.WriteLine("Que conta deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Porcentagem");
            Console.WriteLine("6 - Potenciação");
            Console.WriteLine("7 - Sair");
            Console.WriteLine("--------------");
            Console.WriteLine("Selecione uma opção:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Porcentagem(); break;
                case 6: Potencia(); break;
                case 7: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

            static void Soma()
            {
                Console.Clear();
                Console.WriteLine("Digite o primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                float Result = v1 + v2;

                Console.WriteLine("");
                Console.WriteLine($"O resultado da soma é {Result}.");
                Console.ReadKey();
            }

            static void Subtracao()
            {
                Console.Clear();
                Console.WriteLine("Digite o primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                float Result = v1 - v2;

                Console.WriteLine("");
                Console.WriteLine($"O resultado da subtração é {Result}.");
                Console.ReadKey();
            }

            static void Divisao()
            {
                Console.Clear();
                Console.WriteLine("Digite o primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                float Result = v1 / v2;

                Console.WriteLine("");
                Console.WriteLine($"O resultado da divisão é {Result}");
                Console.ReadKey();
            }

            static void Multiplicacao()
            {
                Console.Clear();
                Console.WriteLine("Digite o primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                float Result = v1 * v2;

                Console.WriteLine("");
                Console.WriteLine($"O resultado da Multiplicação é {Result}");
                Console.ReadKey();
            }

            static void Porcentagem()
            {
                Console.Clear();
                Console.WriteLine("Digite um valor:");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a porcentagem que deseja saber:");
                float v2 = float.Parse(Console.ReadLine());

                float Result = (v2 / 100) * v1;
                Console.WriteLine("");
                Console.WriteLine($"{v2}% de {v1} é igual a: {Result}");
                Console.ReadKey();
            }

            static void Potencia()
            {
                Console.Clear();
                Console.WriteLine("Digite a base:");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a potência:");
                float v2 = float.Parse(Console.ReadLine());

                double Result = Math.Pow(v1, v2);
                Console.WriteLine("");
                Console.WriteLine($"O resultado da potência é {Result}");
                Console.ReadKey();
            }
        }
    }
}