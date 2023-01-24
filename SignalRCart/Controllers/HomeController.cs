using Microsoft.AspNet.SignalR;
using SignalRCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRCart.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(CartCount.count);
        }

        public ActionResult Add()
        {
            // Get the cart items
            CartCount.Add();

            var hubContext = GlobalHost.ConnectionManager.GetHubContext<CartHub>();
            hubContext.Clients.All.UpdateCartCount(CartCount.count, "User");
            return RedirectToAction("Index");
        }

        public ActionResult Remove()
        {
            // Get the cart items
            if (CartCount.count > 0)
            {
                CartCount.Remove();
            }

            var hubContext = GlobalHost.ConnectionManager.GetHubContext<CartHub>();
            hubContext.Clients.All.UpdateCartCount(CartCount.count, "User");
            return RedirectToAction("Index");
        }
    }
}