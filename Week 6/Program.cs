// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

Console.WriteLine("Welcome to Melissa's basic calculator program.");

//var validOperators = new List<string>{"+", "-", "/", "*"};
int firstNumber = 0;
int secondNumber = 0;
string mathCommand = " ";

while(true)
{

    getFirstNumber(firstNumber);

    getSecondNumber(secondNumber);

    //getMathCommand(mathCommand);

    calculateSum(firstNumber, secondNumber, mathCommand);

    continueEscapeKey();
    
    break;
}

    static void getFirstNumber(int firstNumber)
    {
    Console.WriteLine("Please enter the first number in your equation: ");
    int.TryParse(Console.ReadLine(), out firstNumber);

    }
    static void getSecondNumber(int secondNumber)
    {
    Console.WriteLine("Please enter the second number in your equation: ");
    int.TryParse(Console.ReadLine(), out secondNumber);
    }

    // static void getMathCommand(string mathCommand)
    // {
    // Console.WriteLine("Please enter the operator you would like to use (+, -, /, *)");
    // mathCommand = Console.ReadLine()!;
    // }

static void calculateSum(int firstNumber, int secondNumber, string mathCommand)
{

Console.WriteLine("Please enter the operator you would like to use (+, -, /, *)");
mathCommand = Console.ReadLine()!;

while(mathCommand == "+" || mathCommand == "-" || mathCommand == "*" || mathCommand == "/")
{
    switch(mathCommand)
    {
        case "+":
            Console.WriteLine($"Your result: {firstNumber} + {secondNumber} = " + (firstNumber + secondNumber));
            break;
        case "-":
            Console.WriteLine($"Your result: {firstNumber} - {secondNumber} = " + (firstNumber - secondNumber));
            break;
        case "*":
            Console.WriteLine($"Your result: {firstNumber} * {secondNumber} = " + (firstNumber * secondNumber));
            break;
        case "/":
            Console.WriteLine($"Your result: {firstNumber} / {secondNumber} = " + (firstNumber / secondNumber));
            break;

        default:
        Console.WriteLine("Sorry, please make sure you are entering one of the following: +, -, *, /");
        break;
    }
    break;
    }
}
static void continueEscapeKey()
{
Console.WriteLine("Press 'Enter' or 'Return' to continue, or any other key to quit.");
Console.ReadKey();
while (Console.ReadKey().Key != ConsoleKey.Enter) {}
}
