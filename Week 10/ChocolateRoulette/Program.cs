using ChocolateRoulette;
{

//create chocolatebox
var chocolateBox = new List<Chocolate>
{
    new Chocolate(),
    new Chocolate(),
    new ChilliChocolate(),
    new Chocolate(),
    new Chocolate(),
    new ChilliChocolate(),
    new Chocolate(),
    new ChilliChocolate(),
    new Chocolate(),
    new Chocolate(),
    new Chocolate()
};
while(chocolateBox.Count > 0)
{
Console.WriteLine("Press any key to taste a chocolate.");
Console.ReadKey();
//select a chocolate at random
var randomIndexGenerator = new Random();
var IndexOfRandomChocolate = randomIndexGenerator.Next(0, chocolateBox.Count);

var selectedChocolate = chocolateBox[IndexOfRandomChocolate];
chocolateBox.RemoveAt(IndexOfRandomChocolate);

//taste our chocolate
selectedChocolate.Taste();
}
Console.WriteLine("We're all out of chocolates.");
}