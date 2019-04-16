using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Abecedario
{
    class Program


    {
        static void Main(string[] args)
        {

            Task ta = Task.Factory.StartNew(() =>
       {

          // String abcda = "ABCDEFGHHIJKLNOPQRSTUVWXYZ";
           for (int i = 0; 65 < 91; i++)
           {
               if ((char)[i] == 'A' || 'C' || 'E' || 'G' || 'I' || 'K')
               {
                   Console.WriteLine("\t" + (char)i + " ||\t ");
                   System.Threading.Thread.Sleep(10000);
                   Console.ReadKey();
               }





           }




       });






            Task tb = Task.Factory.StartNew(() =>
            {

         //   String abcd = "ABCDEFGHHIJKLNOPQRSTUVWXYZ";
            for (int i = 0; 65 < 91; i++)
            {
                if ((char)[i] == 'B' || 'D' || 'F' || 'H' || 'J' || 'L')
                {
                    Console.WriteLine("\t"+(char)i + "\n \t");
                    System.Threading.Thread.Sleep(10000);
                   

                }
                Console.ReadKey();
            }
           


        });



            Task.WaitAll(ta,tb);

            Console.WriteLine("Finalizo el abecedario esto es main...");
            System.Threading.Thread.Sleep(10000);
            Console.ReadKey();
            Console.ReadLine();
            //String abcd = "ABCDEFGHHIJKLNOPQRSTUVWXYZ";

            /*  for (int i = 65; i < 91; i++)
              {
                  Console.WriteLine((char)i);
              }*/
        }
            
        }
    }

