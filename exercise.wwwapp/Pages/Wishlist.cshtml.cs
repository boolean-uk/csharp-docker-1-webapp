using exercise.wwwapp.Models.Entities;
using exercise.wwwapp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace exercise.wwwapp.Pages
{
    public class WishlistModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private List<Product> _products;
        private List<Teacher> _teachers;
        public WishlistModel(ILogger<IndexModel> logger, IBooleanRepository repository)
        {
            _logger = logger;
            _products = repository.GetProducts();
            _teachers = repository.GetTeachers();
        }
        public void OnGet()
        {
        }
        public List<Teacher> Teachers { get { return _teachers; } }
        public List<Product> Products { get { return _products; } }
        public int teacherId { get; set; }
        public int productId { get; set; }

    }
}
