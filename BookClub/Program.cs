
using BookClub.Models;

var book1 =new Book();
book1.title = "All the light we cannot see";
book1.author = "Anthony Doer";

var book2 =new Book();
book2.title = "The Talented Mr Ripley";
book2.author = "Patricia Highsmith";

var book3 =new Book();
book3.title = "Swimming Lessons";
book3.author = "Claire Fuller";

var book4 =new Book();
book4.title = "The Great Gatsby";
book4.author = "F. Scott Fitzgerald";

var book5 =new Book();
book5.title = "Pachinko";
book5.author = "Min Jin Lee";

var book6 =new Book();
book6.title = "White Teeth";
book6.author = "Zadie Smith";


var books = new List<Book> {book1, book2, book3, book4, book5, book6};

var member1 = new Member();
member1.firstName = "Leslie";
member1.lastName = "Phillip";
member1.favouriteBook = "A Little Life";
member1.readingList = new List<Book>{book1, book2};


var member2 = new Member();
member2.firstName = "Bianca";
member2.lastName = "Nolan";
member2.favouriteBook = "Normal People";
member2.readingList = new List<Book>{book3, book4};


var member3 = new Member();
member3.firstName = "Emma";
member3.lastName = "Brown";
member3.favouriteBook = "The Goldfinch";
member3.readingList = new List<Book>{book5, book6};

var members = new List<Member>{member1, member2, member3};

while(true)
{
    Console.WriteLine("Welcome to our Book Club!");
    Console.WriteLine("");
    Console.WriteLine("What information are you looking for today?");
    Console.WriteLine("Books - View the books recommended by our members.");
    Console.WriteLine("Members - View our current members and thier favourite book.");
    Console.WriteLine("All - View all current members, favourite books, and recommended books.");
    Console.WriteLine("Cancel - Type Cancel to exit this menu");


var userInput = Console.ReadLine()!.ToLower().Trim();

if(userInput == "cancel")
{
    break;
}
{
    switch(userInput)
    {
        case "books":
        Console.WriteLine("Books reccomended by our members:");
        foreach(var book in books)
        {
            Console.WriteLine($"{book.title} by {book.author}");
        }
        break;

        case "members":
        foreach(var member in members)
        {
            Console.WriteLine($"{member.firstName} {member.lastName}");
            Console.WriteLine($"Their favourite book is {member.favouriteBook}");
        }
        break;

        case "all":
        foreach(var member in members)
        {
        member.displayFavouriteBook();
        Console.WriteLine("They would like to read:");
        foreach (var book in member.readingList!)
        {
            Console.WriteLine($"{book.title} by {book.author}");
        }
        Console.WriteLine("");
        }
        break;

        default:
        Console.WriteLine("Please enter an option from the list, or type cancel to exit.");
        break;

        }
        Console.WriteLine("");
    }
}

