namespace LendingLibrary.Models
{
    public class Album : CD
    {
        public string? Artist { get; set;}

        public Album(string title, string artist, int numberOfTracks, int publicationYear)
        {
            Title = title;
            Artist= artist;
            PublicationYear = publicationYear;
            NumberOfTracks = numberOfTracks;
        }
        public void getAlbum()
        {
            Console.WriteLine($"{Title} by {Artist}, {NumberOfTracks} tracks on album, released {PublicationYear}.");
        }
    }
}