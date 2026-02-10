

string input = Console.ReadLine();

double sum = 0;
double total = 0;

while (input != "NoMoreMoney")
{
    sum = double.Parse(input);

    if (sum < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    total += sum;

    Console.WriteLine($"Increase: {sum:F2}");

    input = Console.ReadLine();

    

}

Console.WriteLine($"Total: {total:F2}");