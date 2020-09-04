using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Services.Models
{
    public class AlunoCadastroModel
    {
        [Required]
        public String Nome { get; set; }
        [Required]
        public String Matricula { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public int IdTurma { get; set; }

    }
}