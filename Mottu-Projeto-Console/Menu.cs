using Mottu_Projeto_Console;
using System;

namespace Mottu_Projeto_Console
{
    public class Menu
    {
        private Aluno alunos;
        private Dictionary<string, List<int>> notas;

        public Menu()
        {
            alunos = new Aluno();
            notas = FichaDoAluno.BoletimAluno();
        }

        public void ExibirMenu()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("======= Bem vindo =======    \n" +
                                  " 1) Média sala               \n" +
                                  " 2) Média por aluno          \n" +
                                  " 3) Aluno com melhor nota    \n" +
                                  " 0) Sair                     \n"
                                  );
                Console.Write(" - Opção desejada -> ");
                string opcaoEscolhida = Console.ReadLine()!;
                Console.WriteLine("-------------------------\n");

                switch (opcaoEscolhida)
                {
                    case "1":
                        double mediaSala = alunos.CalcularMediaSala(notas);
                        alunos.ImprimirResultado(" - Média da sala", mediaSala);
                        Final();
                        break;

                    case "2":
                        var notasMediasOrdenadas = alunos.CalcularMediaAlunosOrdenada(notas, true);
                        alunos.ImprimirResultado(" - Notas médias dos alunos (crescente)", notasMediasOrdenadas);
                        Final();
                        break;

                    case "3":
                        var alunoMaiorNota = alunos.EncontrarAlunoMaiorNota(notas);
                        alunos.ImprimirResultado(" - Aluno com maior nota", alunoMaiorNota);
                        Final();
                        break;

                    case "0":
                        Console.WriteLine(" - Até logo...");
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine(" - Opção inválida. Tente novamente.");
                        Final();
                        break;
                }
            }
        }

        private static void Final()
        {
            Console.WriteLine("\n-------------------------\n");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
