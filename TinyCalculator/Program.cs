Console.WriteLine("== Tiny Calculator ==");

int divident;
bool dividentBool;
do
{
    Console.ResetColor();
    Console.Write("Dividend: ");
    dividentBool = int.TryParse(Console.ReadLine(), out divident);
    Console.ForegroundColor = ConsoleColor.Red;
    if (!dividentBool)
        Console.WriteLine("Divident has to be a number!");
} while (!dividentBool);

int divisor;
bool divisorBool;
do
{
    Console.ResetColor();
    Console.Write("Divisor: ");
    divisorBool = int.TryParse(Console.ReadLine(), out divisor);
    Console.ForegroundColor = ConsoleColor.Red;
    if(!divisorBool)
        Console.WriteLine("Divisor has to be a number!");
    else if(divisor == 0)
        Console.WriteLine("Divisor is not allowed to be 0!");
} while (!divisorBool || divisor == 0);

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"{divident}/{divisor} = {divident/divisor}");