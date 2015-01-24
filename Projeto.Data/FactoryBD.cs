using Projeto.Business.Interfaces;
using Projeto.Business.Interfaces.Repository;
using Projeto.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data
{
    public class FactoryBD : IFactory
    {
        /// <summary>
        /// Cria a instância do RepositoryAluno que Herda de RepositoryBase
        /// </summary>
        /// <returns></returns>
        public IRepositoryAluno CreateAlunoBD()
        {
            return new RepositoryAluno();
        }
    }
}
