namespace exercise.wwwapp.Models.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> ProductIds { get; set; } = new List<int>();
    }
}
