using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class SqlController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            var conn = new SqlConnection();
            return View();
        }
    }
}