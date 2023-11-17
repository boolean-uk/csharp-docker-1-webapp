using exercise.wwwapp.Data;
using exercise.wwwapp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace exercise.wwwapp.Controllers
{

    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<IResult> All()
        {
            try
            {
                return await Task.Run(() =>
                {


                    return Results.Ok("Hello");
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IResult> Delete(int id)
        {

            try
            {
                return await Task.Run(() =>
                {
                    ProductInventory.Products.Remove(id);


                    return Results.Redirect("/Index");
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IResult> Add(FormModel model)
        {

            try
            {
                return await Task.Run(() =>
                {
                    ProductInventory.Products.Add(ProductInventory.Products.Count == 0 ? 1 : ProductInventory.Products.Max(x => x.Key) + 1, model.productname);


                    return Results.Redirect("/Index");
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }


    }
}
