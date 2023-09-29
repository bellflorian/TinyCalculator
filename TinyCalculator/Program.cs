Console.WriteLine("== Tiny Calculator ==");

int divident;
bool dividentBool;
do
{
    Console.Write("Dividend: ");
    dividentBool = int.TryParse(Console.ReadLine(), out divident);
} while (!dividentBool);

int divisor;
bool divisorBool;
do
{
    Console.Write("Divisor: ");
    divisorBool = int.TryParse(Console.ReadLine(), out divisor);
} while (!divisorBool);

if(divisor == 0)
    Console.WriteLine("Divisor is not allowed to be 0!");

else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{divident}/{divisor} = {divident/divisor}");
}