namespace BookClub.Models;

public class Member
{
    public string? FirstName;
    public string? LastName;
    public Book? FavouriteBook;

    public List<Book>? ReadingList;

    public void displayFavouriteBook()
    {   
        Console.WriteLine($"Their favourite book is {FavouriteBook?.Title} by {FavouriteBook?.Author}.");
    }
}