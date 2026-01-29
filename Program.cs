

int daysCount = int.Parse(Console.ReadLine());
string roomType = Console.ReadLine();
string review = Console.ReadLine();

int nightsCount = daysCount - 1;
double price = 0;


// total price
if (roomType == "room for one person")
{
    price = 18;
}
else if (roomType == "apartment")
{
    price = 25;
}
else if (roomType == "president apartment")
{
    price = 35;
}

double totalPrice = price * nightsCount;



// discounts
if (roomType == "apartment" && nightsCount > 15)
{
    totalPrice = totalPrice - (totalPrice * 0.50);
}
else if (roomType == "apartment" && nightsCount >= 10)
{
    totalPrice = totalPrice - (totalPrice * 0.35);
}
else if (roomType == "apartment" && nightsCount < 10)
{
    totalPrice = totalPrice - (totalPrice * 0.30);
}

if (roomType == "president apartment" && nightsCount > 15)
{
    totalPrice = totalPrice - (totalPrice * 0.20);
}
else if (roomType == "president apartment" && nightsCount >= 10)
{
    totalPrice = totalPrice - (totalPrice * 0.15);
}
else if (roomType == "president apartment" && nightsCount < 10)
{
    totalPrice = totalPrice - (totalPrice * 0.10);
}

// review price


if (review == "positive")
{
    totalPrice = totalPrice + (totalPrice * 0.25);
}
else if (review == "negative")
{
    totalPrice = totalPrice - (totalPrice * 0.10);
}


Console.WriteLine($"{totalPrice:F2}");