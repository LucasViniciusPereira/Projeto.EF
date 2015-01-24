using Projeto.Business.Entities;
using Projeto.Business.Interfaces;
using Projeto.Business.Interfaces.Repository;
using Projeto.Business.Services;
using Projeto.Data;
using Projeto.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Projeto.UI.Controllers
{
    public class HomeController : BaseController
    {
        protected IRepositoryAluno _repository;

        public HomeController()
        {
            _repository = _factory.CreateAlunoBD();
        }

        public ActionResult Index()
        {
            try
            {
                using (AlunoService svc = new AlunoService(_repository))
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

        public ActionResult List()
        {
            using (AlunoService svc = new AlunoService(_repository))
            {
                var lstAluno = new List<AlunoViewModel>();

                var result = svc.BuscarTodos();

                foreach (var item in result)
                {
                    var model = new AlunoViewModel()
                    {
                        nuMatricula = item.nuMatricula,
                        Nome = item.Nome,
                        Sexo = item.Sexo,
                        DtNascimento = item.DtNascimento
                    };

                    lstAluno.Add(model);
                }

                return View(lstAluno);
            }
        }

        public ActionResult Insert()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public ActionResult CadastrarAluno(AlunoViewModel obj)
        {
            try
            {
                Aluno objAluno = new Aluno
                   {
                       Nome = obj.Nome,
                       DtNascimento = obj.DtNascimento,
                       Sexo = obj.Sexo
                   };

                using (AlunoService svc = new AlunoService(_repository))
                {
                    svc.Cadastrar(objAluno);
                }

                return View("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}