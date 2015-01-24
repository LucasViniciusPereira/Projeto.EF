using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Projeto.UI.Models;

namespace Projeto.UI.ViewModel
{
    public class AlunoViewModel
    {
        [Display(Name = "Numero da Matricula")]
        public int nuMatricula { get; set; }

        public string Nome { get; set; }

        public string Sexo { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DtNascimento { get; set; }

        public int Idade
        {
            get { return Util.CalculaIdade(DtNascimento); }
            private set { this.Idade = value; }
        }
    }
}