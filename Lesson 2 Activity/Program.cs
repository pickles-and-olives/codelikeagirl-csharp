// See https://aka.ms/new-console-template for more information
{
string adjective1, verb, pronoun, adjective2, adjective3;

Console.Write("Enter an adjective: ");
adjective1 = Console.ReadLine();

Console.Write("Enter a verb: ");
verb = Console.ReadLine();

Console.Write("Enter a pronoun: ");
pronoun = Console.ReadLine();

Console.Write("Enter another adjective: ");
adjective2 = Console.ReadLine();

Console.Write("Enter one more adjective: ");
adjective3 = Console.ReadLine();

Console.WriteLine($"My cat is a very " + adjective1 + " creature.");
Console.WriteLine($"She loves to " + verb + "all day, with no regard to " + pronoun + ".");
Console.WriteLine($"But, even when she is " + adjective2 + ", she is still totally " + adjective3 + ".");

Console.ReadLine();

}