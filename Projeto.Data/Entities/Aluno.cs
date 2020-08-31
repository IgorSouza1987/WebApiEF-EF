using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Entities
{
    public class Aluno
    {
        public int IdAluno { get; set; }
        public String Nome { get; set; }
        public String Matricula { get; set; }
        public String Email { get; set; }
        public int IdTurma { get; set; }

        public Turma Turma { get; set; }
    }
}
