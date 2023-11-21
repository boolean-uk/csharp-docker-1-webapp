using exercise.wwwapp.Models;
using exercise.wwwapp.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace exercise.wwwapp.Controllers
{

    [Route("api/[controller]")]
    public class BooleanController : ControllerBase
    {
        private IBooleanRepository _repository;
        public BooleanController(IBooleanRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IResult> All()
        {
            try
            {
                return await Task.Run(() =>
                {
                    AddWishlistModel model =    new AddWishlistModel() { SelectedTeacher = 1, SelectedProduct = 1};

                    return Results.Ok(model);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        [HttpGet("Decrement/{id}")]
        public async Task<IResult> Decrement(int id)
        {

            try
            {
                return await Task.Run(() =>
                {
                    _repository.StockDecrement(id);


                    return Results.Redirect("/Index");
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        [HttpGet("increment/{id}")]
        public async Task<IResult> Increment(int id)
        {

            try
            {
                return await Task.Run(() =>
                {
                    _repository.StockIncrement(id);


                    return Results.Redirect("/Index");
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
                    _repository.Delete(id);


                    return Results.Redirect("/Index");
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IResult> Add(AddProductModel model)
        {

            try
            {
                return await Task.Run(() =>
                {
                    _repository.Add(model.productname);
                    return Results.Redirect("/Index");
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        [HttpGet("wishlist/delete/{teacher}/{product}")]
        public async Task<IResult> DeleteProductToTeacherWishList(int teacher, int product)
        {
            try
            {
                return await Task.Run(() =>
                {

                    _repository.DeleteFromToWishlist(teacher, product);
                    return Results.Redirect("/Teachers");
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        [HttpPost("addwish")]
        public async Task<IResult> AddProductToTeacherWishList()
        {
            try
            {
                return await Task.Run(() =>
                {
                    int teacherId = int.Parse(Request.Form["TeacherSelect"]!);
                    int productId = int.Parse(Request.Form["ProductSelect"]!);
                    _repository.AddToWishlist(teacherId, productId);
                    return Results.Redirect("/Teachers");
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }


    }
}
