// See https://aka.ms/new-console-template for more information
{
Console.Write("Initial deposit: ");
var deposit = int.Parse(Console.ReadLine());


Console.Write("Monthly interest rate (as percentage): ");
var interestAsPercentage = double.Parse(Console.ReadLine());

Console.Write("Number of Months: ");
var months = int.Parse(Console.ReadLine());


var savings = deposit * Math.Pow(1 + (interestAsPercentage/100),months);
Console.WriteLine($"Total Savings: " + savings); 
Console.WriteLine();

}
