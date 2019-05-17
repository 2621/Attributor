using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        /// <summary>
        /// Processamento inicial da solicitação e criação de uma instância do modelo
        /// </summary>
        /// <returns>view da página Index</returns>
        public ActionResult Index()
        {
            return View();
            //acessa files Index.chstml, _Layout.chstml para o Layout da página
        }
    }
}