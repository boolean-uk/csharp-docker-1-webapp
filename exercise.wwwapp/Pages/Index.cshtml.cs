using exercise.wwwapp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercise.wwwapp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Stock = ProductHelper.Products;

        foreach (var kvp in Stock)
        {
            Product p = new Product() { Id = kvp.Key, Name = kvp.Value };
            Products.Add(p);
        }
    }   
    public Dictionary<int,string> Stock { get; set; } = new Dictionary<int,string>();
    public List<Product> Products { get; set; } = new List<Product>();
}
