using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore_jn375.Infrastructure;
using Bookstore_jn375.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookstore_jn375.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBookstoreRepository repo { get; set; }
        public Cart cart { get; set; }
        public string ReturnUrl { get; set; }
        public PurchaseModel(IBookstoreRepository temp, Cart c)
        {
            repo = temp;
            cart = c;
        }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Books p = repo.Books.FirstOrDefault(x => x.BookId == bookId);
            cart.AddItem(p, 1);
            return RedirectToPage(new { ReturnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int bookId, string returnUrl)
        {
            cart.RemoveItem(cart.Items.First(x => x.Books.BookId == bookId).Books);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
