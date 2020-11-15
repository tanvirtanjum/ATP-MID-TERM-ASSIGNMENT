using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ch24ShoppingCartMVC.Models.ViewModels
{
    public class CheckoutViewModel
    {
        public List<ProductViewModel> Cart { get; set; }

        public double TaxRate { 
            get 
            {
                return 0.075;
            } 
        }
        public double Total {
            get 
            {
                double sum = 0;
                foreach(var item in Cart)
                {
                    sum += (double)(item.UnitPrice) * (item.Quantity);
                }
                return sum;
            } 
        }
        public List<string> PaymentOptions 
        {
            get
            {
                List<string> options = new List<string>();
                options.Add("Visa");
                options.Add("MasterCard");
                options.Add("PayPal");
                return options;
            }
        }

        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

    }
}