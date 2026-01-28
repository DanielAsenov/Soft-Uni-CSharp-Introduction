

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
char symbol = char.Parse(Console.ReadLine());


double result = 0;

if (symbol == '+')
{
    result = num1 + num2;
    if (result % 2 == 0)
    {
        Console.WriteLine($"{num1} + {num2} = {result} - even");
    }
    else
    {
        Console.WriteLine($"{num1} + {num2} = {result} - odd");
    }
}
else if (symbol == '-')
{
    result = num1 - num2;
    if (result % 2 == 0)
    {
        Console.WriteLine($"{num1} - {num2} = {result} - even");
    }
    else
    {
        Console.WriteLine($"{num1} - {num2} = {result} - odd");
    }
}
else if (symbol == '*')
{
    result = num1 * num2;
    if (result % 2 == 0)
    {
        Console.WriteLine($"{num1} * {num2} = {result} - even");
    }
    else
    {
        Console.WriteLine($"{num1} * {num2} = {result} - odd");
    }
}
else if (symbol == '/')
{
    if (num1 == 0 || num2 == 0)
    {
        Console.WriteLine($"Cannot divide {num1} by zero");
    }
    else
    {
        result = (double)num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {result:F2}");
    }
}
else if (symbol == '%')
{
    if (num1 == 0 || num2 == 0)
    {
        Console.WriteLine($"Cannot divide {num1} by zero");
    }
    else
    {
        result = num1 % num2;
        Console.WriteLine($"{num1} % {num2} = {result}");
    }
}


