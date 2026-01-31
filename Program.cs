

double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

double price = 0;
string location = "";
string place = "";


if (budget <= 1000)
{
    place = "Camp";
    if (season == "Summer")
    {
        location = "Alaska";
        price = budget * 0.65;
    }
    else if (season == "Winter")
    {
        location = "Morocco";
        price = budget * 0.45;
    }
}
else if (budget > 1000 && budget <= 3000)
{
    place = "Hut";
    if (season == "Summer")
    {
        location = "Alaska";
        price = budget * 0.80;
    }
    else if (season == "Winter")
    {
        location = "Morocco";
        price = budget * 0.60;
    }
}
else if (budget > 3000)
{
    place = "Hotel";
    if (season == "Summer")
    {
        location = "Alaska";
        price = budget * 0.90;
    }
    else if (season == "Winter")
    {
        location = "Morocco";
        price = budget * 0.90;
    }
}

Console.WriteLine($"{location} - {place} - {price:F2}");