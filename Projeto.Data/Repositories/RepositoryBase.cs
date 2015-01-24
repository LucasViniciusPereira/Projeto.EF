using Projeto.Business.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Repositories
{
    public abstract class RepositoryBase<T> : IDisposable, IRepository<T> where T : class
    {
        //Propriedade de contexto do banco de dados
        protected Context ctx = null;

        /// <summary>
        /// Criação da instancia do context que HERDA do DBContext
        /// </summary>
        public RepositoryBase()
        {
            ctx = new Context();
        }

        public void Insert(T objeto)
        {
            ctx.Set<T>().Add(objeto);
        }

        public void Update(T objeto)
        {
            ctx.Entry(objeto).State = EntityState.Modified;
        }

        public void Delete(T objeto)
        {
           ctx.Set<T>().Remove(objeto);
        }

        public List<T> SelectAll()
        {
            var result = ctx.Set<T>().ToList();
            return result;
        }

        public void Dispose()
        {
            if(ctx != null)
                ctx = null;
        }

        public void SaveChanges()
        {
            ctx.SaveChanges();
        }
    }
}
