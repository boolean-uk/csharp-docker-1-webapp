using exercise.wwwapp.Repository;

namespace exercise.wwwapp.Helpers
{
    public class BooleanHelper : IBooleanHelper
    {
        IBooleanRepository _repository;
        public BooleanHelper(IBooleanRepository repository)
        {
            _repository = repository;
        }
        public string GetProductName(int id)
        {
            return _repository.GetProductName(id);
        }
        public int GetStockValueFromProductId(int id)
        {
            return _repository.GetStockValueFromProductId(id);
        }
    }
}
