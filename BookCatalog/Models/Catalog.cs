namespace BookCatalog.Models
{
    public class Catalog
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required string Genre { get; set; }
        public int Year { get; set; }
    }
}
