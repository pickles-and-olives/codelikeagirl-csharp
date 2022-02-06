// See https://aka.ms/new-console-template for more information
var member1 = new Member
{
    firstName = "Leslie",
    lastName = "Phillip",
    favouriteBook = "A Little Life",
    memberReadingList = "All The Light We Cannot See by Anthony Doer, and The Talented Mr Ripley by Patricia Highsmith."
};

var member2 = new Member();
member2.firstName = "Bianca";
member2.lastName = "Nolan";
member2.favouriteBook = "Normal People";
member2.memberReadingList = "Swimming Lessons by Claire Fuller, and The Great Gatsby by F. Scott Fitzgerald.";


var member3 = new Member();
member3.firstName = "Emma";
member3.lastName = "Brown";
member3.favouriteBook = "The Goldfinch";
member3.memberReadingList = "Pachinko by Min Jin Lee, and White Teeth by Zadie Smith";


var members = new List<Member>
{
member1, member2, member3
};

foreach(var member in members)
{
member.displayFavouriteBook();
member.displayReadingList();
}

// var member1ReadingList =new Book
// {
// title = "All the light we cannot see",
// author = "Anthony Doer"
// };

// var member1ReadingList =new Book
// {
// title = "The Talented Mr Ripley",
// author = "Patricia Highsmith"
// };

// var member2ReadingList =new Book{
//     title = "Swimming Lessons",
//     author = "Claire Fuller"
// };

// var member2ReadingList =new Book{
//     title = "The Great Gatsby",
//     author = "F. Scott Fitzgerald"
//};

// var member3ReadingList =new Book{
//     title = "Pachinko",
//     author = "Min Jin Lee"
// };

// var member3ReadingList =new memberReadingList
// {
//     title = "White Teeth",
//     author = "Zadie Smith"
// };

public class Member
{
    public string? firstName;
    public string? lastName;
    public string? favouriteBook;
    public string? memberReadingList;

    public void displayFavouriteBook()
    {
        Console.WriteLine($"{firstName} {lastName}'s favourite book is {favouriteBook}.");
    }

    public void displayReadingList()
    {
        Console.WriteLine($"{firstName} {lastName} has the following books on their reading list: {memberReadingList}.");
    }
}

// public class memberReadingList
// {
//     public string? title;
//     public string? author;

// }

