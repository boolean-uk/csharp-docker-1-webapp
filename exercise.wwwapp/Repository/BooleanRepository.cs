using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using exercise.wwwapp.Data;
using exercise.wwwapp.Models.Entities;

namespace exercise.wwwapp.Repository
{
   
    public class BooleanRepository : IBooleanRepository
    {
        public List<Teacher> GetTeachers()
        {
            return DataStore.Teachers;
        }
        public List<Product> GetProducts()
        {
            return DataStore.Products;
        }
        public string GetProductName(int id)
        {
            if (DataStore.Products.Count == 0) return string.Empty;
            if (!DataStore.Products.Any()) return string.Empty;
            if (!DataStore.Products.Any(p => p.Id==id)) return string.Empty;

            var entity = DataStore.Products.FirstOrDefault(x => x.Id == id);
            return entity.Name;
        }
        public bool AddToWishlist(int teacherId, int ProductId)
        {
            if(!DataStore.Teachers.Any(t => t.Id==teacherId)) return false;
            if (!DataStore.Products.Any(p => p.Id==ProductId)) return false;

            var teacher = DataStore.Teachers.FirstOrDefault(x => x.Id==teacherId);
            if (teacher!=null)
            {
                teacher.ProductIds.Add(ProductId);
                return true;                
            }
            return false;
        }
        public bool DeleteFromToWishlist(int teacherId, int ProductId)
        {
            if (!DataStore.Teachers.Any(t => t.Id == teacherId)) return false;
            if (!DataStore.Products.Any(p => p.Id == ProductId)) return false;

            var teacher = DataStore.Teachers.FirstOrDefault(x => x.Id == teacherId);
            if (teacher != null)
            {
                teacher.ProductIds.Remove(ProductId);
                return true;
            }
            return false;
        }
        public bool Add(string product)
        {
            if(string.IsNullOrEmpty(product)) return false;
            if (DataStore.Products.Any(p => p.Name.ToLower() == product.ToLower())) return false;

            int newId = DataStore.Products.Count == 0 ? 1 : DataStore.Products.Max(x => x.Id) + 1;
            Product item = new Product() { Id = newId, Name = product };
            DataStore.Products.Add(item);
            return true;

        }

        public bool Delete(int id)
        {
            if (!DataStore.Products.Any(p => p.Id == id)) return false;

            DataStore.Products.RemoveAll(x => x.Id == id);
            
            foreach(Teacher t in DataStore.Teachers)
            {
                if(t.ProductIds.Contains(id))
                {
                    t.ProductIds.RemoveAll(x => x == id);
                }
            }
            return true;

        }

        public int GetStockValueFromProductId(int id)
        {
            if (!DataStore.Products.Any(x => x.Id == id)) return -1;
            var item = DataStore.Products.FirstOrDefault(x => x.Id == id);
            return item!.StockCount;
        }
        public bool StockIncrement(int id)
        {
            if (DataStore.Products.Any(p => p.Id == id))
            {
                var item = DataStore.Products.FirstOrDefault(x => x.Id == id);
                item!.StockCount = item.StockCount + 1;
                return true;
            }
            return false;
        }

        public bool StockDecrement(int id)
        {
            if (DataStore.Products.Any(p => p.Id == id))
            {
                var item = DataStore.Products.FirstOrDefault(x => x.Id == id);
                item.StockCount = item.StockCount == 0 ? 0 : item.StockCount = item.StockCount - 1;
                return true;
            }
            return false;
        }


    }
}