using EagerLoadinglazyLoading.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EagerLoadinglazyLoading.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IRepository _repository;
        public AuthorController(IRepository authorRepository)
        {
            _repository = authorRepository;
        }
        [HttpGet("EagerLoading")]
        public ActionResult GetAuthorByEagerLoading()
        {
            var authors = _repository.GetAll().Include(authors => authors.Books).ToList();
            return Ok(authors);
        }
        [HttpGet("LazyLoading")]
        public ActionResult GetAuthorsByLazyLoading()
        {
            var authors = _repository.GetAll().ToList();
            authors.ForEach(author =>
            {
                author.Books = _repository.GetBooksByAuthorId(author.Id);
            });
            return Ok(authors);
        }
    
    }
}
