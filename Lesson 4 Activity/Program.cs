// See https://aka.ms/new-console-template for more information

var randomGenerator = new Random();
int i = randomGenerator.Next(1,11); //Generated number
// var x = 0; //Count of guesses

while(i != j)
{
    Console.WriteLine("Guess a number from 1 to 10: ");
    var j = 0; //Guessed number
    int.TryParse(Console.ReadLine(),out j); 

    while(1 <= j && i <= 10)
    {
        if(i == j)
        {
            Console.WriteLine("You guessed correctly!");
            break;
        }
        else if(i != j)
        {
            Console.WriteLine("Your guess was not correct.");
        }
        else
        {
            Console.WriteLine("Please try again! (Up to 3 chances)");
        
        }
    }
    Console.WriteLine("Please ensure you are entering a number between 1 and 10 (inclusive).");
}
