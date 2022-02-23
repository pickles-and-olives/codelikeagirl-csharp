namespace LendingLibrary.Models
{
    public class Novel : Book
    {
        public string? Genre { get; set; }
        public Novel(string title, string author, int publicationYear, string genre)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Genre = genre;
        }
        public void getNovel()
        {
            Console.WriteLine($"{Title} by {Author}, published {PublicationYear}, Genre:{Genre}.");
        }
    }
}