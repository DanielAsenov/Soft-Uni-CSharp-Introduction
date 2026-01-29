
double budget = double.Parse(Console.ReadLine());
string ticketType = Console.ReadLine();
int numberOfPeople = int.Parse(Console.ReadLine());

double vipTicketPrice = 499.99;
double normalTicketPrice = 249.99;
double transportPrice = 0;


// transport price

if (numberOfPeople >= 50)
{
    transportPrice = budget * 0.25;
}
else if (numberOfPeople >= 25)
{
    transportPrice = budget * 0.40;
}
else if (numberOfPeople >= 10)
{
    transportPrice = budget * 0.50;
}
else if (numberOfPeople >= 5)
{
    transportPrice = budget * 0.60;
}
else
{
    transportPrice = budget * 0.75;
}

double remainingMoney = budget - transportPrice;



// tickets price
if (ticketType == "VIP")
{
    vipTicketPrice *= numberOfPeople;
}
else if (ticketType == "Normal")
{
    normalTicketPrice *= numberOfPeople;
}


// total price

if (ticketType == "VIP" && remainingMoney >= vipTicketPrice)
{
    Console.WriteLine($"Yes! You have {remainingMoney - vipTicketPrice:F2} leva left.");
}
else if (ticketType == "VIP" && remainingMoney < vipTicketPrice)
{
    Console.WriteLine($"Not enough money! You need {vipTicketPrice - remainingMoney:F2} leva.");
}


if (ticketType == "Normal" && remainingMoney >= normalTicketPrice)
{
    Console.WriteLine($"Yes! You have {remainingMoney - normalTicketPrice:F2} leva left.");
}
else if (ticketType == "Normal" && remainingMoney < normalTicketPrice)
{
    Console.WriteLine($"Not enough money! You need {normalTicketPrice - remainingMoney:F2} leva.");
}

