using Projeto.Business.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business.Interfaces
{
    public interface IFactory
    {
        IRepositoryAluno CreateAlunoBD();
    }
}
