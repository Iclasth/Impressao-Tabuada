using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    public class Tab
    {
        public static void ImprimirTabuadaDeDez()
        {
            int x = 10;
            Console.WriteLine("A seguir, a tabuada de 10:");
           for (int cont = 0; cont < 11; cont++)
            {
                int result = x * cont;
                Console.WriteLine($"{x} X {cont} = {result}");
            }
        }
    }
}
