


string season = Console.ReadLine();
string groupType = Console.ReadLine();
int numberOfPeople = int.Parse(Console.ReadLine());
int numberOfNights = int.Parse(Console.ReadLine());


double price = 0;
string vacationType = "";


if (groupType == "boys" || groupType == "girls")
{
    if (season == "Winter")
    {
        price = 9.60;
    }
    else if (season == "Spring")
    {
        price = 7.20;
    }
    else if (season == "Summer")
    {
        price = 15;
    }
}
else if (groupType == "mixed")
{
    if (season == "Winter")
    {
        price = 10;
    }
    else if (season == "Spring")
    {
        price = 9.50;
    }
    else if (season == "Summer")
    {
        price = 20;
    }
}

double totalPrice = price * numberOfPeople * numberOfNights;

if (numberOfPeople >= 50)
{
    totalPrice = totalPrice * 0.50;
}
else if (numberOfPeople >= 20 && numberOfPeople < 50)
{
    totalPrice = totalPrice * 0.85;
}
else if (numberOfPeople >= 10 && numberOfPeople < 20)
{
    totalPrice = totalPrice * 0.95;
}


if (groupType == "girls")
{
    if (season == "Winter")
    {
        vacationType = "Gymnastics";
    }
    else if (season == "Spring")
    {
        vacationType = "Athletics";
    }
    else if (season == "Summer")
    {
        vacationType = "Volleyball";
    }
}
else if (groupType == "boys")
{
    if (season == "Winter")
    {
        vacationType = "Judo";
    }
    else if (season == "Spring")
    {
        vacationType = "Tennis";
    }
    else if (season == "Summer")
    {
        vacationType = "Football";
    }
}
else if (groupType == "mixed")
{
    if (season == "Winter")
    {
        vacationType = "Ski";
    }
    else if (season == "Spring")
    {
        vacationType = "Cycling";
    }
    else if (season == "Summer")
    {
        vacationType = "Swimming";
    }
}


Console.WriteLine($"{vacationType} {totalPrice:F2} lv.");
