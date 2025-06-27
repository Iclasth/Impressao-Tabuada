using System;

namespace Tabuada
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Bem-vindo ao programa de tabuada!");
                Console.WriteLine("Digite um numero de 1 a 10 no qual você deseja ver a tabuada: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Tab.ImprimirTabuadaDeUm();
                        break;
                    case "2":
                        Tab.ImprimirTabuadaDeDois();
                        break;
                    case "3":
                        Tab.ImprimirTabuadaDeTres();
                        break;
                    case "4":
                        Tab.ImprimirTabuadaDeQuatro();
                        break;
                    case "5":
                        Tab.ImprimirTabuadaDeCinco();
                        break;
                    case "6":
                        Tab.ImprimirTabuadaDeSeis();
                        break;
                    case "7":
                        Tab.ImprimirTabuadaDeSete();
                        break;
                    case "8":
                        Tab.ImprimirTabuadaDeOito();
                        break;
                    case "9":
                        Tab.ImprimirTabuadaDeNove();
                        break;
                    case "10":
                        Tab.ImprimirTabuadaDeDez();
                        break;
                    default:
                        Console.WriteLine("Número inválido. Por favor, digite um número de 1 a 10.");
                        break;
                }

                Console.WriteLine("\nDeseja ver a tabuada de outro número? (s/n)\n");
                string resposta = Console.ReadLine().ToLower();
                if (resposta != "s")
                {
                    continuar = false;
                    Console.WriteLine("Obrigado por usar o programa de tabuada!");
                }
               
            }
        }
    }
}
