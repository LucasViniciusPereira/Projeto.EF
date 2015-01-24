using Projeto.Business.Interfaces.Repository;
using Projeto.Business.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business.Services
{
    public abstract class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        //Utilizando inversão de controle no IRepository
        protected readonly IRepository<TEntity> repository;

        /// <summary>
        /// Construtor da classe, informe o repositorio para ele fazer o Padrao IoC
        /// </summary>
        /// <param name="_repository">passe o repositorio para o service</param>
        public ServiceBase(IRepository<TEntity> _repository)
        {
            this.repository = _repository;
        }

        /// <summary>
        /// Metodo de cadastrar generico, Apenas informe no construtor da classe qual o repositório
        /// </summary>
        /// <param name="obj">Objeto entidade para Salvar</param>
        public void Cadastrar(TEntity obj)
        {
            try
            {
                repository.Insert(obj);
                SalvarAlteracoes();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Metodo de Atualizar generico, Apenas informe no construtor da classe qual o repositório
        /// </summary>
        /// <param name="obj">Objeto entidade para Atualizar</param>
        public void Atualizar(TEntity obj)
        {
            try
            {
                repository.Update(obj);
                SalvarAlteracoes();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Metodo de Deletar generico, Apenas informe no construtor da classe qual o repositório
        /// </summary>
        /// <param name="obj">Objeto entidade para Deletar</param>
        public void Deletar(TEntity obj)
        {
            try
            {
                repository.Delete(obj);
                SalvarAlteracoes();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Metodo de Buscar Todos generico, Apenas informe no construtor da classe qual o repositório
        /// </summary>
        public List<TEntity> BuscarTodos()
        {
            try
            {
               var result = repository.SelectAll();

               return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Metodo de Salvar generico, Apenas informe no construtor da classe qual o repositório
        /// </summary>
        public void SalvarAlteracoes()
        {
            repository.SaveChanges();
        }

        public void Dispose()
        {
            repository.Dispose();
        }
    }
}
