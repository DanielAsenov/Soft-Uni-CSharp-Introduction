

string month = Console.ReadLine();
int nightsSpent = int.Parse(Console.ReadLine());


double studioCost = 0;
double apartmentCost = 0;
double totalCostStudio = 0;
double totalCostApartment = 0;

if (month == "May" || month == "October")
{
    apartmentCost = 65;
    studioCost = 50;
    if (nightsSpent > 7 && nightsSpent <= 14)
    {
        studioCost *= 0.95;
        totalCostStudio = studioCost * nightsSpent;

        totalCostApartment = apartmentCost * nightsSpent;
    }
    else if (nightsSpent > 14)
    {
        apartmentCost *= 0.90;
        totalCostApartment = apartmentCost * nightsSpent;

        studioCost *= 0.70;
        totalCostStudio = studioCost * nightsSpent;
    }
    else
    {
        totalCostStudio = studioCost * nightsSpent;
        totalCostApartment = apartmentCost * nightsSpent;
    }
}
else if (month == "June" || month == "September")
{
    apartmentCost = 68.70;
    studioCost = 75.20;

    if (nightsSpent > 14)
    {
        studioCost *= 0.80;
        totalCostStudio = studioCost * nightsSpent;

        apartmentCost *= 0.90;
        totalCostApartment = apartmentCost * nightsSpent;
    }
    else
    {
        totalCostApartment = apartmentCost * nightsSpent;
        totalCostStudio = studioCost * nightsSpent;
    }
}
else if (month == "July" || month == "August")
{
    studioCost = 76;
    apartmentCost = 77;

    if (nightsSpent > 14)
    {
        apartmentCost *= 0.90;
        totalCostApartment = apartmentCost * nightsSpent;

        totalCostStudio = 76 * nightsSpent;
    }
    else
    {
        totalCostApartment = 77 * nightsSpent;
        totalCostStudio = 76 * nightsSpent;
    }

}
Console.WriteLine($"Apartment: {totalCostApartment:F2} lv.");
Console.WriteLine($"Studio: {totalCostStudio:F2} lv.");

