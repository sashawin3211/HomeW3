using static System.Runtime.InteropServices.JavaScript.JSType;

Console.Write("Enter day number 1-7: ");
string? dayStr = Console.ReadLine();
int day = 0;

bool success = int.TryParse(dayStr, out day);
if (success)
{
    switch (day)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
        default:
            Console.WriteLine("wrong input");
            break;
    }
}
else
{
    Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Input numbers 1 - 7!!!!!!!!!!!!!!");
    Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
}