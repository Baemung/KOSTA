using jsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Basic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Account = Session["account"];
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Account = Session["account"];
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.Account = Session["account"];
            return View();
        }
        public ActionResult Login()
        {
            if(Session["uid"] != null) //쿠키
            {
                return RedirectToAction("Index");
            }

            ViewBag.Message = "Your Login page.";
            
            string uid = Request.QueryString["UID"];
            string pwd = Request.QueryString["PWD"];

            if(uid != null)
            {
                SQLDB db = new SQLDB(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KOSTA\Desktop\KOSTA\Cs\ASP.NET\ASP_DB.mdf;Integrated Security=True;Connect Timeout=30");
                if (db.Get($"select password from users where uid = '{uid}'").ToString().Trim() == UsersController.GetEncrypt(pwd))
                {
                    Session["uid"] = uid;
                    Session["account"] = db.Get($"select account from users where uid = '{uid}'").ToString().Trim();
                    return RedirectToAction("Index");
                }
            }

            return View();
        }
    }
}