using System.Security.Cryptography;

int N1 = int.Parse(Console.ReadLine());
int N2 = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());

double result = 0;

switch (operation)
{
    case '+':
        result = N1 + N2;
        Console.WriteLine($"{N1} + {N2} = {result} - {(result % 2 == 0 ? "even" : "odd")}");
        break;
    case '-':
        result = N1 - N2;
        Console.WriteLine($"{N1} - {N2} = {result} - {(result % 2 == 0 ? "even" : "odd")}");
        break;
    case '*':
        result = N1 * N2;
        Console.WriteLine($"{N1} * {N2} = {result} - {(result % 2 == 0 ? "even" : "odd")}");
        break;
    case '/':
        if (N2 == 0)
        {
            Console.WriteLine($"Cannot divide {N1} by zero");
        }
        else
        {
            double divisionResult = (double)N1 / N2;
            Console.WriteLine($"{N1} / {N2} = {divisionResult:f2}");
        }
        break;
    case '%':
        if (N2 == 0)
        {
            Console.WriteLine($"Cannot divide {N1} by zero");
        }
        else
        {
            int moduloResult = N1 % N2;
            Console.WriteLine($"{N1} % {N2} = {moduloResult}");
        }
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}