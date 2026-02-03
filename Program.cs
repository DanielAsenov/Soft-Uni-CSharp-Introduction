
int n = int.Parse(Console.ReadLine());

double numberOver800 = 0;
double numberOver600 = 0;
double numberOver400 = 0;
double numberOver200 = 0;
double numberUnder200 = 0;


for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (number >= 800)
    {
        numberOver800++;
    }
    else if (number >= 600)
    {
        numberOver600++;
    }
    else if (number >= 400)
    {
        numberOver400++;
    }
    else if (number >= 200)
    {
        numberOver200++;
    }
    else
    {
        numberUnder200++;
    }
}


Console.WriteLine($"{numberUnder200 / n * 100:F2}%");
Console.WriteLine($"{numberOver200 / n * 100:F2}%");
Console.WriteLine($"{numberOver400 / n * 100:F2}%");
Console.WriteLine($"{numberOver600 / n * 100:F2}%");
Console.WriteLine($"{numberOver800 / n * 100:F2}%");
