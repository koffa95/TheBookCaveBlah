using System.Collections.Generic;
using System.Linq;
using TheBookCave.Data;
using TheBookCave.Models.ViewModels;

namespace The_Book_Cave.Repositories
{
    public class AuthorRepo
    {
        private DataContext _db;
        public AuthorRepo()
        {
            _db = new DataContext();
        }
        public List<AuthorListViewModel> GetAllAuthors()
        {
            var authors = (from a in _db.Authors
                          select new AuthorListViewModel
                          {
                              authorId = a.id,
                              name = a.name,
                              age = a.age,
                              alive = a.alive
                          }).ToList();

            return authors;
        }
    }
}