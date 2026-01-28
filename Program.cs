


string fruit = Console.ReadLine();
string day = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double price = 0;
bool isValid = true;

if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
{
    if (fruit == "banana")
    {
        price = 2.50 * quantity;
    }
    else if (fruit == "apple")
    {
        price = 1.20 * quantity;
    }
    else if (fruit == "orange")
    {
        price = 0.85 * quantity;
    }
    else if (fruit == "grapefruit")
    {
        price = 1.45 * quantity;
    }
    else if (fruit == "kiwi")
    {
        price = 2.70 * quantity;
    }
    else if (fruit == "pineapple")
    {
        price = 5.50 * quantity;
    }
    else if (fruit == "grapes")
    {
        price = 3.85 * quantity;
    }
    else
    {
        Console.WriteLine("error");
        isValid = false;
    }


}
else if (day == "Saturday" || day == "Sunday")
{
    if (fruit == "banana")
    {
        price = 2.70 * quantity;
    }
    else if (fruit == "apple")
    {
        price = 1.25 * quantity;
    }
    else if (fruit == "orange")
    {
        price = 0.90 * quantity;
    }
    else if (fruit == "grapefruit")
    {
        price = 1.60 * quantity;
    }
    else if (fruit == "kiwi")
    {
        price = 3.00 * quantity;
    }
    else if (fruit == "pineapple")
    {
        price = 5.60 * quantity;
    }
    else if (fruit == "grapes")
    {
        price = 4.20 * quantity;
    }
    else
    {
        Console.WriteLine("error");
        isValid = false;
    }

}
else
{
    Console.WriteLine("error");
    isValid = false;
}


if (isValid == true)
{
    Console.WriteLine($"{price:F2}");
}





