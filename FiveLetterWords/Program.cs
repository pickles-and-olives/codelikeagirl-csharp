
char userLetter;
var validLetter = new List<char>{'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 's', 't', 'u', 'v', 'w', 'y', 'z'};
string letterList = "";
userLetter = getUserLetter();
letterList = getLetterList();

char getUserLetter()
    {
    Console.WriteLine("Enter the first letter of the word:");
    char.TryParse(Console.ReadLine(), out var userLetter);
    return userLetter;
    }

string getLetterList()
    {
    System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/FiveLetterWords/txtfiles/" + $"{userLetter}.txt");
    return letterList;
    }

Console.WriteLine($"5 letter words beginning with {userLetter}:");
Console.WriteLine($"{letterList}");
Console.WriteLine($"{validLetter}.txt", validLetter);

Console.WriteLine("Press any key to exit.");
Console.ReadKey();




    


