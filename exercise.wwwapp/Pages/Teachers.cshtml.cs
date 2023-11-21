using exercise.wwwapp.Models.Entities;
using exercise.wwwapp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercise.wwwapp.Pages
{
    public class TeachersModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private List<Product> _products;
        private List<Teacher> _teachers;

        public TeachersModel(ILogger<IndexModel> logger, IBooleanRepository repository)
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


    }
}
