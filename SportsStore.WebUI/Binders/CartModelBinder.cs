using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsStore.Domain.Entities;
using System.Web.Mvc;

namespace SportsStore.WebUI.Binders
{
    public class CartModelBinder:IModelBinder
    {
        private const string seesionKey = "Cart";

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            //get the Cart from the session
            Cart cart = (Cart)controllerContext.HttpContext.Session[seesionKey];
            //create the cart if there wasn't one in the session data
            if (cart == null)
            {
                cart = new Cart();
                controllerContext.HttpContext.Session[seesionKey] = cart;
            }
            //return the cart
            return cart;
        }
    }
}