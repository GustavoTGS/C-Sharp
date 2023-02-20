using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aux = 3;
            string[] alunos = new string[4] { "Gustavo", "Thais","Wilian",""};
            string decisao = "", decisao2 = "";
            int[] notas = new int[4] { 9, 9, 10, 0 };

            Imprimir(alunos, notas);
            Console.WriteLine("Deseja adicionar um aluno? Y ou N");
            decisao = Console.ReadLine();
            switch (decisao)
            {
                case "Y":
                    {
                        AdicionarALuno(alunos, notas, aux);
                        aux++;
                        break;
                    }
                case "N":
                    {
                        Console.WriteLine("Remover um aluno? Y ou N");
                        decisao2 = Console.ReadLine();
                        switch (decisao2)
                        {
                            case "Y":
                                {
                                    RemoverAluno(alunos, notas, aux);
                                    Imprimir(alunos, notas);
                                    break;
                                }
                            case "N":
                                {
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Goodbye");
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Goodbye");
                        break;
                    }
            }
            Console.Clear();
            Imprimir(alunos, notas);
            Console.WriteLine(aux);
            Console.ReadKey();
        }

        public static void Imprimir(string[]alunos, int[]notas)
        {
            for(int percorrer = 0; percorrer  < alunos.Length; percorrer++)
            {
                Console.WriteLine("Nome: " + alunos[percorrer]);
                Console.WriteLine("Nota do aluno: " + notas[percorrer]);
                if (notas[percorrer] >= 7) 
                {
                    Console.WriteLine("APROVADO");
                } else if (notas[percorrer] >= 5 && notas[percorrer] <7)
                {
                    Console.WriteLine("RECUPERAÇÃO");
                } else
                {
                    Console.WriteLine("REPROVADO");
                }
                Console.WriteLine("\n");
            }
        }

        public static void AdicionarALuno(string[] alunos, int[] notas, int aux)
        {
            string nome = "";
            int nota = 0;
            Console.WriteLine("Digite nome do aluno");
            nome = Console.ReadLine();
            Console.WriteLine("A nota dele");
            nota = int.Parse(Console.ReadLine());
            alunos[aux] = nome;
            notas[aux] = nota;
        }
        public static void RemoverAluno(string[] alunos, int[] notas, int aux )
        {
            int removePos = 0;
            Imprimir(alunos, notas);
            Console.WriteLine("Qual a posição do aluno a ser removido? EX: 0,1,2...");
            removePos = int.Parse(Console.ReadLine());
            aux = removePos;
            alunos[removePos] = "";
            notas[removePos] = 0;
        }
        public static int ProcurarPosVazia(int[]notas, int aux)
        {
            for(int percorrer = 0; percorrer<notas.Length; percorrer++)
            {
                if (notas[percorrer] == 0)
                {
                    aux = notas[percorrer];
                }
            }
            return aux;
        }
    }
}
