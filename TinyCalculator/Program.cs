Console.WriteLine("== Tiny Calculator ==");

bool first = true;
int divident = 0;
do
{
    Console.WriteLine();
    if (first)
    {
        divident = GetInt("Divident", false);
    }
    first = false;
    int divisor = GetInt("Divisor", true);
    int result = divident / divisor;
    Console.WriteLine($"{divident}/{divisor} = {result}");
    Console.Write("Continue? [Y]: ");
    divident = result;
} while (Console.ReadKey().KeyChar == 'Y');




static int GetInt(string name, bool isDivisor)
{
    int number;
    bool isInt;
    do
    {
        Console.ResetColor();
        Console.Write($"{name}: ");
        isInt = int.TryParse(Console.ReadLine(), out number);
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