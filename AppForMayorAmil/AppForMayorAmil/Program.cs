using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForMayorAmil
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,i,valor,cont=0;

            Console.WriteLine("programa que muestre los numeros iguales o mayores a Mil");
            Console.WriteLine("digite la cantidad de numeros:");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                Console.WriteLine("Digite numero: ");
                valor = int.Parse(Console.ReadLine());
                Console.WriteLine("numero: "+i+"valor");

                if (valor >= 1000)
                {
                    Console.WriteLine("El numero es mayor");
                    cont++;
                }
            }

            Console.WriteLine("la cantida de numeros mayores son: "+cont);
            Console.ReadKey();



        }
    }
}
