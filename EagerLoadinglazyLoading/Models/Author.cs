namespace EagerLoadinglazyLoading.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }    
        //here we use virtual keyword for lazy loading
    }
}
