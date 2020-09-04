using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models
{
    public class TurmaCadastroModel
    {

        [Required]
        public String Codigo { get; set; }

        [Required]
        public String Disciplina { get; set; }

    }
}