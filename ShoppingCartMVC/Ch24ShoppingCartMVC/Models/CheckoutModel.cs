using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ch24ShoppingCartMVC.Models.ViewModels;

namespace Ch24ShoppingCartMVC.Models
{
    public class CheckoutModel
    {
        public List<ProductViewModel> GetCartFromDataStore()
        {
            List<ProductViewModel> cart;
            object objCart = HttpContext.Current.Session["cart"];

            cart = (List<ProductViewModel>)objCart;

            if(cart==null)
            {
                objCart = new List<ProductViewModel>();
                cart = (List<ProductViewModel>)objCart;
            }
            return cart;
        }
        public CheckoutViewModel GetCheckout()
        {
            CheckoutViewModel model = new CheckoutViewModel();
            model.Cart = GetCartFromDataStore();
            return model;
        }
        
    }
}