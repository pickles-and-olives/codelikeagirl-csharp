namespace LendingLibrary.Models
{
    public class AudioBook : CD
    {
        public string? Author { get; set;}
        public string? Narrator { get; set; }

        public AudioBook(string title, string author, string narrator, int numberOfTracks, int publicationYear)
        {
            Title = title;
            Author= author;
            Narrator = narrator;
            PublicationYear = publicationYear;
            NumberOfTracks = numberOfTracks;
        }
        public void getAudioBook()
        {
            Console.WriteLine($"{Title} by {Author}, read by {Narrator}. {NumberOfTracks} tracks on album, this recording released {PublicationYear}.");
        }
    }
}
