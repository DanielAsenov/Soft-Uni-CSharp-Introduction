

int juniorRacers = int.Parse(Console.ReadLine());
int seniorRacers = int.Parse(Console.ReadLine());
string raceType = Console.ReadLine();


double juniorsPrice = 0;
double seniorsPrice = 0;


if (raceType == "trail")
{
    juniorsPrice += 5.50;
    seniorsPrice += 7.00;
}
else if (raceType == "cross-country")
{
    juniorsPrice += 8.00;
    seniorsPrice += 9.50;

    if (juniorRacers + seniorRacers >= 50)
    {
        juniorsPrice = juniorsPrice - (juniorsPrice * 0.25);
        seniorsPrice = seniorsPrice - (seniorsPrice * 0.25);
    }
}
else if (raceType == "downhill")
{
    juniorsPrice += 12.25;
    seniorsPrice += 13.75;
}
else if (raceType == "road")
{
    juniorsPrice += 20;
    seniorsPrice += 21.50;
}

double totalPrice = (juniorRacers * juniorsPrice) + (seniorRacers * seniorsPrice);

Console.WriteLine($"{totalPrice * 0.95:F2}");