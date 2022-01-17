// See https://aka.ms/new-console-template for more information

var randomGenerator = new Random();
int i = randomGenerator.Next(1,11); //Generated number
int j = 0; //User input
int guessCount = 0;

while(guessCount <= 3)
{
while(j != i)
{
    guessCount++;

    Console.WriteLine("Guess a number from 1 to 10: ");
    int.TryParse(Console.ReadLine(), out j);

    if(j > i)
    {
        Console.WriteLine("Your guess was too high.");
        Console.WriteLine($"You have guessed {guessCount} times");
    }
    else if(j < i)
    {
        Console.WriteLine("Your guess was too low.");
        Console.WriteLine($"You have guessed {guessCount} times");
    }
    else
    {
        Console.WriteLine("You guessed correctly!");
    }
}
}
