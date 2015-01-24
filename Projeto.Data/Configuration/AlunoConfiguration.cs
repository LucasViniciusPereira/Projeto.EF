using Projeto.Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Configuration
{
    /// <summary>
    /// Configuração da Classe Aluno, o EF pega essas configurações para a criação da Tabela no Banco de dados
    /// </summary>
    public class AlunoConfiguration : EntityTypeConfiguration<Aluno>
    {
        public AlunoConfiguration()
        {
            //Chave primária
            HasKey(x => x.nuMatricula);

            Property(x => x.Sexo)
                    .IsRequired();

        }
    }
}
