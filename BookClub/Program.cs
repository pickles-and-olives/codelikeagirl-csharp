
using BookClub.Models;

var book1 =new Book
{
title = "All the light we cannot see",
author = "Anthony Doer"
};

var book2 =new Book
{
title = "The Talented Mr Ripley",
author = "Patricia Highsmith"
};

var book3 =new Book{
    title = "Swimming Lessons",
    author = "Claire Fuller"
};

var book4 =new Book{
    title = "The Great Gatsby",
    author = "F. Scott Fitzgerald"
};

var book5 =new Book{
    title = "Pachinko",
    author = "Min Jin Lee"
};

var book6 =new Book
{
    title = "White Teeth",
    author = "Zadie Smith"
};

var bookList = new List<Book> {book1, book2, book3, book4, book5, book6};

var member1 = new Member();
member1.firstName = "Leslie";
member1.lastName = "Phillip";
member1.favouriteBook = "A Little Life";
member1.readingList = new List<Book>{bookList[1], bookList[2]};


var member2 = new Member();
member2.firstName = "Bianca";
member2.lastName = "Nolan";
member2.favouriteBook = "Normal People";
member2.readingList = new List<Book>{bookList[3], bookList[4]};


var member3 = new Member();
member3.firstName = "Emma";
member3.lastName = "Brown";
member3.favouriteBook = "The Goldfinch";
member3.readingList = new List<Book>{book5, book6};


var members = new List<Member>
{
member1, member2, member3
};

foreach(var member in members)
{
member.displayFavouriteBook();
Console.WriteLine("They would like to read:");
foreach (var book in member.readingList!)
        {
            Console.WriteLine($"{book.title} by {book.author}");
        }
}
