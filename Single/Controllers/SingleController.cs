using Single.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Single.Controllers
{
    public class SingleController : Controller
    {
        // GET: Single
        public ActionResult Index()
        {
           ViewBag.ClientName = "聊客-" + Guid.NewGuid().ToString("N");
        
            var onLineUserList = MyHub.OnLineUsers.Select(u => new SelectListItem() { Text = u.Value, Value = u.Key }).ToList();
           onLineUserList.Insert(0, new SelectListItem() { Text = "-所有人-", Value = "" });
            ViewBag.OnLineUsers = onLineUserList;
            return View();
        }

    }
}