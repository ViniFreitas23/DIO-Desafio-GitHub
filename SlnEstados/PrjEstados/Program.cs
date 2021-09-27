using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjEstados
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] estado = new string[3,3];
            int num=0;
            int ref2=0;

            while (num < 3){
                Console.WriteLine("Digite o estado: ");
                estado[num,0] = Console.ReadLine();
                Console.WriteLine("Digite a capital: ");
                estado[num,1] = Console.ReadLine();
                Console.WriteLine("Digite o numero de habitantes: ");
                estado[num,2] = Console.ReadLine();
                num = num + 1;
            }
            Console.WriteLine("\nESTADO\tCAPITAL\t\tNº habitantes");     
            while (ref2 < 3){
                Console.WriteLine(estado[ref2,0] + "\t" + estado[ref2,1] + "\t" + estado[ref2,2]);
                ref2 = ref2 + 1;
            }
            Console.ReadLine();
        }
    }
}
