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

    // public void addMember(List<Member> members)
    // {
    //     Console.WriteLine("What is the first name of the new member?");
    //     var newFirstName = Console.ReadLine();
    //     Console.WriteLine("What is the last name of the new member?");
    //     var newLastName = Console.ReadLine();
    //     Console.WriteLine("What is the new member's favourite book?");
    //     var newFavourite = Console.ReadLine();

    //     var newMember = new Member()
    //     {
    //         firstName = newFirstName,
    //         lastName = newLastName,
    //         favouriteBook = newFavourite
    //     };
    // while(true)
    // {
    //         members.Add(newMember);
    // }
    //     }

  

    }


