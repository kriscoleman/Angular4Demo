namespace ComicBookStoreAPI.Models
{
    /// <summary>
    /// A Comicbook
    /// </summary>
    public class Comic
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Issue { get; set; }

        public string Publisher { get; set; }

        public int Quantity { get; set; }

        public decimal Cost { get; set; }
    }
}