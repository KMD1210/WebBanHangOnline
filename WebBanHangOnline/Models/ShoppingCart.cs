using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models
{
    public class ShoppingCart
    {
        public List<ShoppingCartItem> Items { get; set; }
        public ShoppingCart()
        {
            this.Items = new List<ShoppingCartItem>();
        }

        public void AddToCart(ShoppingCartItem item,int SoLuong)
        {
            var checkExits = Items.FirstOrDefault(x => x.ProductId == item.ProductId);
            if (checkExits != null)
            {
                checkExits.SoLuong += SoLuong;
                checkExits.TotalPrice = checkExits.Gia * checkExits.SoLuong;
            }
            else
            {
                Items.Add(item);
            }
        }

        public void Remove(int id)
        {
            var checkExits = Items.SingleOrDefault(x=>x.ProductId==id);
            if (checkExits != null)
            {
                Items.Remove(checkExits);
            }
        }

        public void UpdateQuantity(int id,int quantity)
        {
            var checkExits = Items.SingleOrDefault(x => x.ProductId == id);
            if (checkExits != null)
            {
                checkExits.SoLuong = quantity;
                checkExits.TotalPrice = checkExits.Gia * checkExits.SoLuong;
            }
        }

        public decimal GetTotalPrice()
        {
            return Items.Sum(x=>x.TotalPrice);
        }
        public int GetTotalQuantity()
        {
            return Items.Sum(x => x.SoLuong);
        }
        public void ClearCart()
        {
            Items.Clear();
        }

    }

    public class ShoppingCartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string biDanh { get; set; }
        public string CategoryName { get; set; }
        public string ProductImg { get; set; }
        public int SoLuong { get; set; }
        public decimal Gia { get; set; }
        public decimal TotalPrice { get; set; }
    }
}