using System.Diagnostics;

double numberOne = new();
double numberTwo = new();
string? strNumberOne = null;
string? strNumberTwo = null;
string mathType = "";
Console.Write("input num one: ");
strNumberOne = Console.ReadLine();
Console.Write("input num two: ");
strNumberTwo = Console.ReadLine();
Console.Write("input / * + -");
mathType = Console.ReadLine();  

//SOME FUN;
//Process.Start("Calc.exe"); :)

numberOne = Convert.ToDouble(strNumberOne);
numberTwo = Convert.ToDouble(strNumberTwo);

switch (mathType) {
    case "*":
        Console.WriteLine($"Result is :{numberOne*numberTwo}");
        break;
    case "/":
        Console.WriteLine($"Result is :{numberOne / numberTwo}");
        break;
    case "-":
        Console.WriteLine($"Result is :{numberOne - numberTwo}");
        break;
    case "+":
        Console.WriteLine($"Result is :{numberOne + numberTwo}");
        break;
    default:
        Console.WriteLine("Wrong input");
        break;  
}

