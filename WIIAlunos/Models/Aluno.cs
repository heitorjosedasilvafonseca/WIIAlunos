using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WIIAlunos.Models
{
    public class Aluno
    {
        public long AlunoId { get; set; }
        public long Matricula { get; set; }
        public string Nome { get; set; }
    }
}