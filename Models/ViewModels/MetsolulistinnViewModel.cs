namespace TheBookCave.Models.ViewModels
{
    public class MetsolulistinnViewModel
    {
        public int bookId {get; set;}
        public string title {get; set; }
        public int authorId {get; set;}
        public string translator {get; set;}
        public string originalLanguage {get; set;}
        public string languages {get; set;}
        public int pages {get; set;}
        public int price {get; set;}

    }
    
}