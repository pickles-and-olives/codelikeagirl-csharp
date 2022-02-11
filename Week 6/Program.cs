// See https://aka.ms/new-console-template for more information
using System;
//using System.Collections.Generic;

Console.WriteLine("Welcome to Melissa's basic calculator program.");

//var validOperators = new List<string>{"+", "-", "/", "*"};
int firstNumber;
int secondNumber;
char mathCommand;
//var exitCommand = "x";

    {

        firstNumber = getFirstNumber();

        secondNumber = getSecondNumber();

        mathCommand = getMathCommand();

        calculateSum(firstNumber, secondNumber, mathCommand);
        
    }

        static int getFirstNumber()
        {
        Console.WriteLine("Please enter the first number in your equation: ");
        int.TryParse(Console.ReadLine(), out int firstNumber);
        return firstNumber;
        }
        static int getSecondNumber()
        {
        Console.WriteLine("Please enter the second number in your equation: ");
        int.TryParse(Console.ReadLine(), out int secondNumber);
        return secondNumber;
        }

        static char getMathCommand()
        {
        Console.WriteLine("Please enter the operator you would like to use (+, -, /, *)");
        char.TryParse(Console.ReadLine(), out var mathCommand);
        return mathCommand;
        //mathCommand = Console.ReadLine()!;
        }

        // static void exitKey(string exit)
        // {
        // Console.WriteLine("Type x if you wish to exit the program.");
        // exit = Console.ReadLine()?.ToLower();
        // while (exit == "x") 
        // {
        //     break;
        // }
        // }

    static void calculateSum(int firstNumber, int secondNumber, char mathCommand)
    {

    // while(mathCommand == "+" || mathCommand == "-" || mathCommand == "*" || mathCommand == "/")
    // {

        switch(mathCommand)
        {
            case '+':
                Console.WriteLine($"Your result: {firstNumber} + {secondNumber} = " + (firstNumber + secondNumber));
                break;

            case '-':
                Console.WriteLine($"Your result: {firstNumber} - {secondNumber} = " + (firstNumber - secondNumber));
                break;

            case '*':
                Console.WriteLine($"Your result: {firstNumber} * {secondNumber} = " + (firstNumber * secondNumber));
                break;

            case '/':
                Console.WriteLine($"Your result: {firstNumber} / {secondNumber} = " + (firstNumber / secondNumber));
                break;

                default:
                Console.WriteLine("Sorry, please make sure you are entering one of the following: +, -, *, /.");
                break;
        }
   }

