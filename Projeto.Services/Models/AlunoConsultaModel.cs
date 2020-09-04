using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models
{
    public class AlunoConsultaModel
    {
        public int IdAluno { get; set; }
        public String Nome { get; set; }
        
        public String Matricula { get; set; }
        
        public String Email { get; set; }
        
        public int IdTurma { get; set; }
    }
}