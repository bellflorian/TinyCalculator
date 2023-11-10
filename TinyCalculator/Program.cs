﻿Console.WriteLine("== Tiny Calculator ==");

char calcTyp = GetCalcType();


double num01 = GetInt("Number 1", false);
double num02;
if (calcTyp == '/')
    num02 = GetInt("Number 2", true);

else
    num02 = GetInt("Number 2", false);

double result;

switch(calcTyp)
{
    case '+': result = num01 + num02; break;
    case '-': result = num01 - num02; break;
    case '*': result = num01 * num02; break;
    case '/': result = num01 / num02; break;
    default: result = 0; break;
}

Console.WriteLine($"{num01}{calcTyp}{num02}={result}");

char GetCalcType()
{
    string userInput;
    do
    {
        Console.Write("Enter Calculation Type [*|/|+|-]: ");
        userInput = Console.ReadLine();
    } while (userInput != "*" && userInput != "/" && userInput !="+" && userInput !="-");
    return Char.Parse(userInput);
}
static double GetInt(string name, bool isDivisor)
{
    double number;
    bool isInt;
    do
    {
        Console.ResetColor();
        Console.Write($"{name}: ");
        isInt = double.TryParse(Console.ReadLine(), out number);
        Console.ForegroundColor = ConsoleColor.Red;
        if (!isInt)
            Console.WriteLine($"{name} has to be a number!");
        else if( isDivisor && number == 0)
        {
            Console.WriteLine("Divisor is not allowed to be 0!");
            isInt = false;
        }
    } while (!isInt);
    Console.ResetColor();
    return number;
}