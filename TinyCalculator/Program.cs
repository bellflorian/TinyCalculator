using Microsoft.VisualBasic;

Console.WriteLine("== Tiny Calculator ==");

bool first = true;
double num01 = 0;
double num02 = 0;

do
{
    Console.WriteLine();

    char calcType = GetCalcType();
    if(first)
        num01 = GetDouble("Number 1", false);

    first = false;

    if (calcType == '/')
        num02 = GetDouble("Number 2", true);

    else
        num02 = GetDouble("Number 2", false);

    double result;

    switch (calcType)
    {
        case '+': result = num01 + num02; break;
        case '-': result = num01 - num02; break;
        case '*': result = num01 * num02; break;
        case '/': result = num01 / num02; break;
        default: result = 0; break;
    }

    Console.WriteLine($"{num01}{calcType}{num02}={result}");
    Console.Write("Continue? [Y]: ");
    num01 = result;
} while (Console.ReadKey().KeyChar == 'Y');


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
static double GetDouble(string name, bool isDivisor)
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