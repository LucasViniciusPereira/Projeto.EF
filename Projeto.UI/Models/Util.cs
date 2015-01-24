using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.UI.Models
{
    public static class Util
    {
        public static int CalculaIdade(DateTime DataNascimento)
        {
            int anos = DateTime.Now.Year - DataNascimento.Year;

            if (DateTime.Now.Month < DataNascimento.Month || (DateTime.Now.Month == DataNascimento.Month && DateTime.Now.Day < DataNascimento.Day))
                anos--;
            
            return anos;
        }
    }
}