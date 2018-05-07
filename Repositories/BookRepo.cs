using System.Collections.Generic;
using System.Linq;
using TheBookCave.Data;
using TheBookCave.Models.ViewModels;

namespace TheBookCave.Repositories
{
    public class BookRepo
    {
        private DataContext _db;
        public BookRepo()
        {
            _db = new DataContext();
        }
        public List<BookListViewModel> GetAllBooks()
        {
            var books = (from a in _db.Books
                          select new BookListViewModel
                          {
                              bookId = a.id,
                              title = a.title,
                              authorId = a.authorId,
                              genre = a.genre,
                              releaseYear = a.releaseYear,
                              publisher = a.publisher,
                              translator = a.translator,
                              originalLanguage = a.originalLanguage,
                              language = a.language,
                              pages = a.pages,
                              price = a.price

                          }).ToList();

            return books;
        }
    }
}