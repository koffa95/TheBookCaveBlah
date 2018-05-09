namespace TheBookCave.Data.EntityModels
{
    public class Author
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public bool alive { get; set; }
        public string countryOfBirth { get; set; }
        public int yearOfBirth { get; set; }
        public string image { get; set; }
        public string shortDescription { get; set; }
    }
}