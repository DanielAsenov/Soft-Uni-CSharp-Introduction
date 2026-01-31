
string season = Console.ReadLine();
double kmPerMonth  = double.Parse(Console.ReadLine());

double salary = 0;

if ((season == "Spring" ||  season == "Autumn") && kmPerMonth <= 5000)
{
    salary = 4 * (kmPerMonth * 0.75);
}
else if ((season == "Spring" || season == "Autumn") && kmPerMonth <= 10000)
{
    salary = 4 *(kmPerMonth * 0.95);
}
else if (season == "Summer" && kmPerMonth <= 5000)
{
    salary = 4 * (kmPerMonth * 0.90);
}
else if (season == "Winter" && kmPerMonth <= 5000)
{
    salary = 4 *  (kmPerMonth * 1.05);
}
else if (season == "Summer" && kmPerMonth <= 10000)
{
    salary = 4 * (kmPerMonth * 1.10);
}
else if (season == "Winter" && kmPerMonth <= 10000)
{
    salary = 4 * (kmPerMonth * 1.25);
}
else if (kmPerMonth <= 20000)
{
    salary = 4 * (kmPerMonth * 1.45)    ;
}

double totalSalary = salary * 0.90;
Console.WriteLine($"{totalSalary:F2}");