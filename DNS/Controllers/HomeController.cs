using DNS.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DNS.Controllers
{
    public class HomeController : Controller
    {
        public  ActionResult Index()
        {
            using (DNSContext db = new DNSContext())
            {
                Product product1 = new Product { Name = "Asus" };

                db.Products.Add(product1);
                db.SaveChanges();
            }

            return View();
        }

        [HttpPost]
        public string PostData(string SName)
        {
            return "Параметр запроса" + SName;
        }
 
    }
}