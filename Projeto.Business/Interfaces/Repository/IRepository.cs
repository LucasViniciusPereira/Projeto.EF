using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {
        void Insert(T objeto);
        void Update(T objeto);
        void Delete(T objeto);
        List<T> SelectAll();
        void SaveChanges();
        void Dispose();
    }
}
