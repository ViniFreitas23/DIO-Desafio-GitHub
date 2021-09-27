using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjContagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para iniciar a contagem:");
            int num = 0;
            while (num <= 0 || num >= 100){
                num = Convert.ToInt32(Console.ReadLine());
                if (num <= 0 || num >= 100){
                    Console.WriteLine("Número inválido!");
                }
            }
            Console.WriteLine("A contagem de " + num + " até 100 é:");
            while (num <= 100) {
                if (num % 2 == 0){
                    Console.WriteLine(num);
                }
                num++;
            }
            Console.ReadLine();
        }
    }
}
