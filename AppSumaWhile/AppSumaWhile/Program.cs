using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSumaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, suma=0, i=1, valor;
            float promedio=0;
            Console.WriteLine(" AppSumaWhile los numeros Ingresados");
            Console.WriteLine(" Ingrese la cantidad de numeros a sumar");
            valor = int.Parse(Console.ReadLine());

            while(i<=valor)
            {
                Console.WriteLine("Digite un numero: ");
                n = int.Parse(Console.ReadLine());
                suma = suma + n;
                i++;

            }

            promedio=suma/valor;
            Console.WriteLine("la suma es: "+suma +"el promedio es: "+promedio);
            Console.ReadKey();
        }
       
    }
   
}
