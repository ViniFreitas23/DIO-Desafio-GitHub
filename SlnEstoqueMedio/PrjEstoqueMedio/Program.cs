using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjEstoqueMedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int qMin, qMax;
            double EstMed;
            Console.WriteLine("Digite a quantidade mínima: ");
            qMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade máxima: ");
            qMax = Convert.ToInt32(Console.ReadLine());
            EstMed = (qMin + qMax) / 2;
            Console.WriteLine("\nO estoque médio é: " + EstMed);
            Console.ReadLine();
        }
    }
}
