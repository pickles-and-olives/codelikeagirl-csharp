using BookClub.Models;

var book1 = new Book("All the light we cannot see", "Anthony Doer");
var book2 = new Book("The Talented Mr Ripley", "Patricia Highsmith");
var book3 = new Book("Swimming Lessons", "Claire Fuller");
var book4 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
var book5 = new Book("Pachinko", "Min Jin Lee");
var book6 = new Book("White Teeth", "Zadie Smith");
var book7 = new Book("Normal People", "Sally Rooney");
var book8 = new Book("The Goldfinch", "Donna Tartt");
var book9 = new Book("A Little Life", "Hanya Yanagihara");

var books = new List<Book> { book1, book2, book3, book4, book5, book6, book7, book8, book9 };

var member1 = new Member();
member1.FirstName = "Leslie";
member1.LastName = "Phillip";
member1.FavouriteBook = new Book("Normal People", "Sally Rooney");
member1.ReadingList = new List<Book> { book1, book2 };


var member2 = new Member();
member2.FirstName = "Bianca";
member2.LastName = "Nolan";
member2.FavouriteBook = book8;
member2.ReadingList = new List<Book> { book3, book4 };


var member3 = new Member();
member3.FirstName = "Emma";
member3.LastName = "Brown";
member3.FavouriteBook = books[8];
member3.ReadingList = new List<Book> { book5, book6 };

var members = new List<Member> { member1, member2, member3 };

while (true)
{
    Console.WriteLine("Welcome to our Book Club!");
    Console.WriteLine("");
    Console.WriteLine("What information are you looking for today?");
    Console.WriteLine("Books - View the books recommended by our members.");
    Console.WriteLine("Members - View our current members and their favourite book.");
    Console.WriteLine("Add Member - Add a new member to the book club.");
    Console.WriteLine("Add Book- Add a new book to the reccomended books list");
    Console.WriteLine("All - View all current members, favourite books, and recommended books.");
    Console.WriteLine("Cancel - Type Cancel to exit this menu");
    Console.WriteLine("");


    var userInput = Console.ReadLine()!.ToLower().Trim();

    if (userInput == "cancel")
    {
        break;
    }
    switch (userInput)
    {
        case "books":
            Console.WriteLine("Books reccomended by our members:");
            Console.WriteLine("");
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author}");
            }
            break;

        case "members":
            foreach (var member in members)
            {
                Console.WriteLine($"{member.FirstName} {member.LastName}");
                member.displayFavouriteBook();
                Console.WriteLine("");
            };
            break;

        case "all":
            foreach (var member in members)
            {
                member.displayFavouriteBook();
                Console.WriteLine("They would like to read:");
                foreach (var book in member.ReadingList!)
                {
                    Console.WriteLine($"{book.Title} by {book.Author}");
                }
            }
            break;

        case "add member":
            Console.WriteLine("What is the first name of the new member?");
            var newFirstName = Console.ReadLine();
            Console.WriteLine("What is the last name of the new member?");
            var newLastName = Console.ReadLine();

            var newMember = new Member()
            {
                FirstName = newFirstName,
                LastName = newLastName
            };
            members.Add(newMember);
            break;

        case "add book":
            Console.WriteLine("What is the title of the book?");
            var newBookTitle = Console.ReadLine();
            Console.WriteLine("Who is the author of the book?");
            var newBookAuthor = Console.ReadLine();

            var newBook = new Book(newBookTitle!, newBookAuthor!)
            {
                Title = newBookTitle,
                Author = newBookAuthor
            };
            books.Add(newBook);
            break;

        default:
            Console.WriteLine("Please enter an option from the list, or type cancel to exit.");
            break;

    }
    Console.WriteLine("");
}
