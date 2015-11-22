using DtoModel;
using LifeInEsbjergGateway;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeInEsbjerg.Controllers
{
    public class CompanyController : Controller
    {
        private Facade facade = new Facade();

        // GET: Company
        public ActionResult Index()
        {
            IEnumerable<Company> companies = facade.GetComapnyGateway().ReadAll();
            Debug.WriteLine(companies);
            return View(companies);
        }
    }
}