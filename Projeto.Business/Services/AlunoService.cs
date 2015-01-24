using Projeto.Business.Entities;
using Projeto.Business.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business.Services
{
    public class AlunoService : ServiceBase<Aluno>
    {
        private readonly IRepositoryAluno _repo;
       
        public AlunoService(IRepositoryAluno _repository)
            :base(_repository)
        {
            this._repo = _repository;
        }

        /// <summary>
        /// Metodo da instância aluno
        /// </summary>
        /// <param name="nuMatricula">Informe o numero da matricula</param>
        /// <param name="nome">Informe o nome do aluno</param>
        /// <returns></returns>
        public List<Aluno> BuscarAluno(int? nuMatricula, string nome)
        {
            try
            {
                var result = _repo.SelectAluno(nuMatricula, nome);

                return result.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
