﻿using Microsoft.AspNetCore.Mvc;
using MyGym.Data.Cart;

namespace MyGym.Data.ViewComponents
{
    
    public class ShoppingCartSummary:ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke() {
            var items = _shoppingCart.GetShoppingCartItems();
            return View(items.Count);
        }
    }
}
