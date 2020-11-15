using Ch24ShoppingCartMVC.Models;
using Ch24ShoppingCartMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ch24ShoppingCartMVC.Controllers
{
    public class CheckoutController : Controller
    {
        //
        // GET: /Checkout/
        public CheckoutModel model = new CheckoutModel();
        public ActionResult Index()
        {
            CheckoutViewModel cModel = model.GetCheckout();
            return View(cModel);
        }

    }
}
