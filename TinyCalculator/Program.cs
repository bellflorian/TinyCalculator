Console.WriteLine("== Tiny Calculator ==");

int divident;
bool dividentBool;
do
{
    Console.Write("Dividend: ");
    dividentBool = int.TryParse(Console.ReadLine(), out divident);
} while (!dividentBool);

return;
int divisor;
bool divisorBool;
do
{
    Console.Write("Divisor: ");
    divisorBool = int.TryParse(Console.ReadLine(), out divisor);
} while (!divisorBool && divisor == 4);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{divident}/{divisor} = {divident/divisor}");