using Projeto.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business.Interfaces.Repository
{
    public interface IRepositoryAluno : IRepository<Aluno>
    {
        List<Aluno> SelectAluno(int? nuMatricula, string nome);
    }
}
