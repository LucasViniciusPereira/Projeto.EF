using Projeto.Business.Entities;
using Projeto.Business.Interfaces;
using Projeto.Business.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Repositories
{
    public class RepositoryAluno :RepositoryBase<Aluno>, IRepositoryAluno
    {
        public List<Aluno> SelectAluno(int? nuMatricula, string nome)
        {
            try
            {
                Expression<Func<Aluno, bool>> predicate = (c) => true;

                if (nuMatricula.HasValue)
                    predicate = (c) => c.nuMatricula == nuMatricula.Value;

                if (string.IsNullOrEmpty(nome) == false)
                    predicate = (c) => c.Nome.StartsWith(nome);

                var result = ctx.Set<Aluno>().Where(predicate);

                return result.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
