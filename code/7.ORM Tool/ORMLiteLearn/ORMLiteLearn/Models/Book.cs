namespace ORMLiteLearn.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public decimal Price { get; set; }
        public int Rating { get; set; }
        public string URL { get; set; } = string.Empty!;
        public DateTime PublishDate { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
