using exercise.wwwapp.Models.Entities;

namespace exercise.wwwapp.Data
{
    public static class DataStore
    {
        public static List<Product> Products { get; set; } = new List<Product>();
        public static List<Teacher> Teachers { get; set; } = new List<Teacher>();

        public static void Initialize()
        {
            Products.Add(new Product() { Id = 1, Name = "Boolean Branded Shades", StockCount=99 });
            Products.Add(new Product() { Id = 2, Name = "Boolean Branded Beanie", StockCount = 10 });
            Products.Add(new Product() { Id = 3, Name = "Boolean Branded Hoodie", StockCount = 50 });
            Products.Add(new Product() { Id = 4, Name = "Boolean Branded Tee Blue", StockCount= 400 });
            Products.Add(new Product() { Id = 5, Name = "Boolean Branded Socks", StockCount=0 });
            Products.Add(new Product() { Id = 6, Name = "Boolean Branded Cardigan", StockCount = 99 });
            Products.Add(new Product() { Id = 7, Name = "Boolean Branded Mouse Mat", StockCount= 1000 });
            Products.Add(new Product() { Id = 8, Name = "Boolean Duck", StockCount = 1000 });
            Products.Add(new Product() { Id = 9, Name = "Boolean C# Sticker", StockCount = 1000 });
            Products.Add(new Product() { Id = 10, Name = "Boolean Java Sticker", StockCount = 3 });


            Teachers.Add(new Teacher() { Id = 1, Name = "Luca", ProductIds = { 2, 8, 9 } });
            Teachers.Add(new Teacher() { Id = 2, Name = "Dave", ProductIds = { 2, 8, 9, 10} });
            Teachers.Add(new Teacher() { Id = 3, Name = "Nathan", ProductIds = { 2, 8, 9 } });
            Teachers.Add(new Teacher() { Id = 4, Name = "Lewis", ProductIds = { 2, 8, 7, 9} });
            Teachers.Add(new Teacher() { Id = 5, Name = "Jules", ProductIds = { 2,9, 8, 7 ,  9} });
            Teachers.Add(new Teacher() { Id = 6, Name = "Nigel", ProductIds = { 3, 8, 7, 9} });
            Teachers.Add(new Teacher() { Id = 7, Name = "Ludovica", ProductIds = { 3, 8, 7, 9 } });
            Teachers.Add(new Teacher() { Id = 8, Name = "Carlo", ProductIds = { 3, 8, 7, 9 } });

        }
    }
}
