
var member1 = new Member
{
    firstName = "Leslie",
    lastName = "Phillips",
    favouriteBook = "A Little Life",
};

var member2 = new Member
{
    firstName = "Bianca",
    lastName = "Nolan",
    favouriteBook = "Normal People",
};

var member3 = new Member
{
    firstName = "Emma",
    lastName = "Brown",
    favouriteBook = "The Goldfinch",
};

var members = new List<Member>
{
member1, member2, member3
};

foreach(var member in members)
{
member.displayFavouriteBook();
}
public class Member
{
    public string? firstName;
    public string? lastName;
    public string? favouriteBook;

    public void displayFavouriteBook()
    {
        Console.WriteLine($"{firstName} {lastName}'s favourite book is {favouriteBook}.");
    }
}




