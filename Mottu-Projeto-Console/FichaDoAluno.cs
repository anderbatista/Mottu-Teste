using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mottu_Projeto_Console
{
    public class FichaDoAluno
    {
        public static Dictionary<string, List<int>> BoletimAluno()
        {
            return new Dictionary<string, List<int>>
            {
                { "aluno3", new List<int> { 4, 3, 3 } },
                { "aluno7", new List<int> { 5, 6, 5 } },
                { "aluno1", new List<int> { 3, 4, 10, 4, 10, 10, 10, 1 } },
                { "aluno6", new List<int> { 10, 9, 10 } },
                { "aluno5", new List<int> { 3, 4, 10 } },
                { "aluno4", new List<int> { 3, 4, 10 } },
                { "aluno2", new List<int> { 3, 4, 10 } }
            };
        }
    }
}
