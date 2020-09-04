using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models
{
    public class TurmaEdicaoModel
    {
        [Required]
        public int IdTurma { get; set; }
        [Required]
        public String Codigo { get; set; }
    }
}