using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjCalculoComissao
{
    class Program
    {
        static void Main(string[] args)
        {
            string codFunc, codPeca;
            double valor, quantidade, comissao;
            Console.WriteLine("Digite um código do funcionário: ");
            codFunc = Console.ReadLine();
            Console.WriteLine("Digite o código da peça: ");
            codPeca = Console.ReadLine();
            Console.WriteLine("Digite o valor unitário: ");
            valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade vendida: ");
            quantidade = Convert.ToDouble(Console.ReadLine());
            comissao = valor * quantidade * 0.02;
            comissao = Math.Round(comissao, 2);
            Console.WriteLine("\nA comissão do funcionário " + codFunc + "\nsobre a venda da peça " + codPeca + " foi de R$" + comissao);
            Console.ReadLine();
        }
    }
}
