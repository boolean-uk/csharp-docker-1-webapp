using exercise.wwwapp.Models.Entities;

namespace exercise.wwwapp.Repository
{
    public interface IBooleanRepository
    {
        //Teacher related
        List<Teacher> GetTeachers();
        bool AddToWishlist(int teacherId, int ProductId);
        bool DeleteFromToWishlist(int teacherId, int ProductId);

        //Product related
        string GetProductName(int id);
        List<Product> GetProducts();
        bool Add(string product);
        bool Delete(int id);
        
        int GetStockValueFromProductId(int id);
        bool StockDecrement(int id);
        bool StockIncrement(int id);
        
    }
}
