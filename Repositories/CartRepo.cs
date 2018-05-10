using System.Collections.Generic;
using System.Linq;
using TheBookCave.Data;
using TheBookCave.Data.EntityModels;
using TheBookCave.Models.ViewModels;

namespace TheBookCave.Repositories
{
    public class CartRepo
    {
        private DataContext _db;
        public CartRepo()
        {
            _db = new DataContext();
        }
        public List<CartViewModel> GetCart()
        {
            var cart = (from c in _db.Cart
                        select new CartViewModel
                        {
                            id = c.id,
                            book = c.book
                        }).ToList();

            return cart;
        }
    }
}