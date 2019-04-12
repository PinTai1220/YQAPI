using BLL;
using Commen;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YQApi.Controllers
{
    public class HomeController : Controller
    {
        //private IDataservices<Blogs, BlogsBLL> _dataservices;
        //public IDataservices<Blogs, BlogsBLL> Dataservices
        //{
        //    get
        //    {
        //        if (_dataservices != null)
        //        {
        //            return _dataservices;
        //        }
        //        return null;
        //    }
        //    set
        //    {
        //        if (_dataservices is null)
        //        {
        //            _dataservices = value;
        //        }
        //    }
        //}



        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
