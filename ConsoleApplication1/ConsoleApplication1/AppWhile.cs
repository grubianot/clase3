using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int piezas,  contador=1;
            float longitud;

            Console.WriteLine("FABRICA DE PERFILES");
            Console.WriteLine("iNGRESE EL NUMERO DE PIEZAS: ");
            piezas = int.Parse(Console.ReadLine());
       
            while (contador<=piezas){
                
                Console.WriteLine("lea longitud: ");
                longitud = float.Parse(Console.ReadLine());

                if (longitud >= 1.20 && longitud >= 1.30)
                {
                    Console.WriteLine("la pieza " + longitud + " es apta");
                    contador++;
                }
                else
                {
                    Console.WriteLine("la pieza " + longitud + "  no es apta");
                    contador++;
                }
                
            }

          Console.ReadKey();
            
             }  

        }
    }

