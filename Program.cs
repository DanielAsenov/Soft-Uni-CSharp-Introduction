



int kilomtresTravelled = int.Parse(Console.ReadLine());
string dayOrNight = Console.ReadLine();

double dayPrice = 0;
double nightPrice = 0;
double totalPrice = 0;
double taxiStartPrice = 0.70;
double totalTaxiPrice = taxiStartPrice + 0;



if (dayOrNight == "day" && kilomtresTravelled < 20)
{
    dayPrice = kilomtresTravelled * 0.79 + taxiStartPrice;
    totalPrice = dayPrice;
}
else if (dayOrNight == "night" && kilomtresTravelled < 20)
{
    nightPrice = kilomtresTravelled * 0.90 + taxiStartPrice;
    totalPrice = nightPrice;
}



if (kilomtresTravelled >= 20 && kilomtresTravelled < 100)
{
    totalPrice = 0.09 * kilomtresTravelled;
}

else if (kilomtresTravelled >= 100)
{
    totalPrice = 0.06 * kilomtresTravelled;
}









Console.WriteLine($"{totalPrice:F2}");