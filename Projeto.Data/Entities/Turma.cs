using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Entities
{
   public class Turma
    {
        public int IdTurma { get; set; }
        public String Codigo { get; set; }
        
        public List<Aluno> Alunos { get; set; }

    }
}
