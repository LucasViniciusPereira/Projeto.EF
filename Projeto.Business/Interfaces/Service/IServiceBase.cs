using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business.Interfaces.Service
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Cadastrar(TEntity obj);

        void Atualizar(TEntity obj);

        void Deletar(TEntity obj);

        List<TEntity> BuscarTodos();

        void SalvarAlteracoes();

        void Dispose();
    }
}
