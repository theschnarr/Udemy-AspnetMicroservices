﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Entities
{
	public class ShoppingCart
	{
		public ShoppingCart()
		{

		}
		public ShoppingCart(string userName)
		{
			UserName = userName;
		}

		public string UserName { get; set; }
		public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

		public decimal TotalPrice
		{
			get
			{
				var totalPrice = 0m;
				foreach (var item in Items)
				{
					totalPrice += item.Price * item.Quantity;
				}

				return totalPrice;
			}
		}
	}
}
