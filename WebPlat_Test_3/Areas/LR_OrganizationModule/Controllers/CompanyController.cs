using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPlat_Test_3.Areas.LR_OrganizationModule.Controllers
{
    public class CompanyController : Controller
    {
        // GET: LR_OrganizationModule/Company

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}