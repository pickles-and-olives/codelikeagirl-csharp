namespace BookClub.Models;

public class Member
{
    public string? firstName;
    public string? lastName;
    public string? favouriteBook;

    public List<Book>? readingList;

    public void displayFavouriteBook()
    {
        Console.WriteLine($"{firstName} {lastName}'s favourite book is {favouriteBook}.");
    }
}

