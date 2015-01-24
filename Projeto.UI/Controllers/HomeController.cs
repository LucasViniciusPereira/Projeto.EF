using Projeto.Business.Interfaces;
using Projeto.Business.Interfaces.Repository;
using Projeto.Business.Services;
using Projeto.Data;
using System;
using System.Web.Mvc;

namespace Projeto.UI.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            try
            {
                IRepositoryAluno repo = _factory.CreateAlunoBD();

                using (AlunoService svc = new AlunoService(repo))
                {
                    var result = svc.BuscarAluno(1, null);
                }

                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}