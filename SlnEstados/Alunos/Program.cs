using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aluno = new string[5];
            string[] sobrenome = new string[5];
            int i = 1;

            while (i < 6)
            {
                Console.WriteLine("Digite o nome do aluno " + i + ":");
                aluno[i-1] = Console.ReadLine();
                Console.WriteLine("Digite o sobrenome do aluno " + i + ":");
                sobrenome[i - 1] = Console.ReadLine();
                i++;
            }
            i = 0;
            Console.WriteLine("Lista de nomes:");
            while (i < 5)
            {
                Console.WriteLine(aluno[i] + " " + sobrenome[i]);
                i++;
            }
            Console.ReadLine();
        }
    }
}
