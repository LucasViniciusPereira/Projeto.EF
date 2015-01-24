using Projeto.Business.Interfaces;
using Projeto.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.UI.Controllers
{
    public class BaseController : Controller
    {
        //Propriedade do factory
        protected readonly IFactory _factory;

        public BaseController()
        {
            //Atribuindo a instancia do factory
            _factory = new FactoryBD();
        }
    }
}