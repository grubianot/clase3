using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i=1;
            Console.WriteLine("Mostrar numero del 1 al N");
            Console.WriteLine("Digite el numero:  ");
            n = int.Parse(Console.ReadLine());

            
            while(i<=n)
            {
                Console.WriteLine(i);
                    i++;
            }

            
            

            Console.ReadKey();
        }
    }
}
