using EagerLoadinglazyLoading.Models;

namespace EagerLoadinglazyLoading.Repositories
{
    public interface IRepository
    {
        public IQueryable<Author> GetAll();
        public List<Book> GetBooksByAuthorId(int authorId);
    }
}
