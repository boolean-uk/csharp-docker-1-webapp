using exercise.wwwapp.Data;
using exercise.wwwapp.Models.Entities;
using exercise.wwwapp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercise.wwwapp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private List<Product> _products;
    public IndexModel(ILogger<IndexModel> logger, IBooleanRepository repository)
    {
        _logger = logger;
        _products = repository.GetProducts();
    }

    public void OnGet()
    {

    }
    public List<Product> Products { get { return _products; } }
}
