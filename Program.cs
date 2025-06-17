using System;
namespace Tabuada
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tab tabuada = new Tab();
            Tab.ImprimirTabuadaDeDez();


            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();


        }
    }
   
}
