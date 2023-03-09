using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_jn375.Models
{
    public class Cart
    {
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>();

        public void AddItem(Books proj, int qty)
        {
            CartLineItem line = Items
                .Where(p => p.Books.BookId == proj.BookId)
                .FirstOrDefault();
            if (line == null)
            {
                Items.Add(new CartLineItem
                {
                    Books = proj,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Books.Price);
            return sum;
        }
    }
    public class CartLineItem
    {
        public int LineId { get; set; }
        public Books Books { get; set; }
        public int Quantity { get; set; }
    }
}
