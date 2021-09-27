using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjMediaSemestral
{
    class Program
    {
        static void Main(string[] args)
        {
            int faltas;
            double notaSem1, notaSem2, media;
            string nome;
            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o numero de faltas: ");
            faltas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a nota do 1º Semestre: ");
            notaSem1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do 2º Semestre: ");
            notaSem2 = Convert.ToDouble(Console.ReadLine());
            media = (notaSem1 + notaSem2) / 2;
            media = Math.Round(media, 2);
            Console.WriteLine("*********************");
            if (faltas > 12)
            {
                Console.WriteLine("Aluno: " + nome + "\nMédia: " + media + "\nFaltas: " + faltas + "\nStatus: Repetido por Faltas (RF)");
            }else{
                if (media >= 7 && media <= 10)
                {
                    Console.WriteLine("Aluno: " + nome + "\nMédia: " + media + "\nFaltas: " + faltas + "\nStatus: Aprovado!");
                }
                else if (media >= 5 && media < 7)
                {
                    Console.WriteLine("Aluno: " + nome + "\nMédia: " + media + "\nFaltas: " + faltas + "\nStatus: Recuperação");
                }
                else if (media >= 0 && media < 5)
                {
                    Console.WriteLine("Aluno: " + nome + "\nMédia: " + media + "\nFaltas: " + faltas + "\nStatus: Reprovado!");
                }
                else
                {
                    Console.WriteLine("Erro!");
                }
            }
            Console.WriteLine("*********************");
            Console.ReadLine();
        }
    }
}
