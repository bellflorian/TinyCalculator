Console.WriteLine("== Tiny Calculator ==");

int divident = GetInt("Divident", false);
int divisor = GetInt("Divisor", true);

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"{divident}/{divisor} = {divident/divisor}");

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

    return number;
}