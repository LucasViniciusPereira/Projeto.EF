using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business.Entities
{
    public class Aluno
    {
        public int nuMatricula { get; set; }

        public string Nome { get; set; }

        public string Sexo { get; set; }

        public DateTime DtNascimento { get; set; }

    }
}
