using System;
using System.Collections.Generic;
using System.Linq;

namespace Mottu_Projeto_Console
{
    public class Aluno
    {
        public void ExecutarCalculos()
        {
            Dictionary<string, List<int>> notas = FichaDoAluno.BoletimAluno();

            double mediaSala = CalcularMediaSala(notas);
            ImprimirResultado("Média da sala", mediaSala);

            var notasMediasOrdenadas = CalcularMediaAlunosOrdenada(notas, true);
            ImprimirResultado("Notas médias dos alunos (crescente)", notasMediasOrdenadas);

            var notasMediasDecrescentes = CalcularMediaAlunosOrdenada(notas, false);
            ImprimirResultado("Notas médias dos alunos (decrescente)", notasMediasDecrescentes);

            var alunoMaiorNota = EncontrarAlunoMaiorNota(notas);
            ImprimirResultado("Aluno com maior nota", alunoMaiorNota);
        }

        public double CalcularMediaSala(Dictionary<string, List<int>> notas)
        {
            return notas.Values.SelectMany(notas => notas).Average();
        }

        public List<Tuple<string, double>> CalcularMediaAlunosOrdenada(Dictionary<string, List<int>> notas, bool crescente)
        {
            var notasMediasOrdenadas = notas
                .Select(aluno => new Tuple<string, double>(aluno.Key, aluno.Value.Average()))
                .OrderBy(aluno => aluno.Item2, crescente ? Comparer<double>.Default : Comparer<double>.Create((x, y) => y.CompareTo(x)))
                .ToList();

            return notasMediasOrdenadas;
        }

        public Tuple<string, double> EncontrarAlunoMaiorNota(Dictionary<string, List<int>> notas)
        {
            var alunoMaiorNota = notas
                .Select(aluno => new Tuple<string, double>(aluno.Key, aluno.Value.Average()))
                .OrderByDescending(aluno => aluno.Item2)
                .First();

            return alunoMaiorNota;
        }

        public void ImprimirResultado(string titulo, double resultado)
        {
            Console.WriteLine($"{titulo}: {resultado:F2}");
        }

        public void ImprimirResultado(string titulo, List<Tuple<string, double>> resultados)
        {
            Console.WriteLine($"\n{titulo}:");
            foreach (var resultado in resultados)
            {
                Console.WriteLine($"{resultado.Item1}: {resultado.Item2:F2}");
            }
        }

        public void ImprimirResultado(string titulo, Tuple<string, double> resultado)
        {
            Console.WriteLine($"{titulo}: {resultado.Item1}, Nota: {resultado.Item2:F2}");
        }
    }
}
