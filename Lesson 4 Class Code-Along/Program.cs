// See https://aka.ms/new-console-template for more information
Console.WriteLine("Out of the following, what sort of movie do you feel like watching? \nFunny, Scary, Thrilling, Inspiring");
var typeOfFilm = Console.ReadLine();

string filmTitle;

if(typeOfFilm == "Funny" || typeOfFilm == "funny" || typeOfFilm == "FUNNY")
{
    filmTitle = "Booksmart";
}

else if(typeOfFilm == "Scary" || typeOfFilm == "scary" || typeOfFilm == "SCARY")
{
    filmTitle = "Get Out";
}

else if(typeOfFilm == "Thrilling" || typeOfFilm == "thrilling" || typeOfFilm == "THRILLING")
{
    filmTitle = "No Time To Die";
}

else if(typeOfFilm == "Inspiring" || typeOfFilm == "inspiring" || typeOfFilm == "INSPIRING")
{
    filmTitle = "The Intouchables";
}

else 
{
    filmTitle = "Harry Potter";
}

Console.WriteLine($"I reccomend you watch {filmTitle}.");