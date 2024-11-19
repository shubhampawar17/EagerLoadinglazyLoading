using EagerLoadinglazyLoading.Data;
using EagerLoadinglazyLoading.Models;

namespace EagerLoadinglazyLoading.Repositories
{
    public class Repository : IRepository
    {
        private readonly BookContext _bookContext;
        public Repository(BookContext bookContext)
        {
            _bookContext = bookContext;
        }
        public IQueryable<Author> GetAll()
        {
            return _bookContext.Authors.AsQueryable();
        }

        public List<Book> GetBooksByAuthorId(int authorId)
        {
            return _bookContext.Books.Where(book =>  book.AuthorId == authorId).ToList();   
        }
    }
}
