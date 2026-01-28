

string fuelType = Console.ReadLine();
double fuelAmount = double.Parse(Console.ReadLine());
string discountCard = Console.ReadLine();

double fuelPrice = 0;

double gasolinePrice = 2.22;
double dieselPrice = 2.33;
double gasPrice = 0.93;
double discountPerLiter = 0;

if (discountCard == "Yes")
{
    if (fuelType == "Gasoline")
    {
        discountPerLiter = gasolinePrice - 0.18;
        fuelPrice = discountPerLiter * fuelAmount;
    }
    else if (fuelType == "Diesel")
    {
        discountPerLiter = dieselPrice - 0.12;
        fuelPrice = discountPerLiter * fuelAmount;
    }
    else if (fuelType == "Gas")
    {
        discountPerLiter = gasPrice - 0.08;
        fuelPrice = discountPerLiter * fuelAmount;
    }
}
else
{
    if (fuelType == "Gasoline")
    {
        fuelPrice = gasolinePrice * fuelAmount;
    }
    if (fuelType == "Diesel")
    {
        fuelPrice = dieselPrice * fuelAmount;
    }
    if (fuelType == "Gas")
    {
        fuelPrice = gasPrice *fuelAmount;
    }
 
}

if (fuelAmount > 25)
{
    if (fuelType == "Gasoline")
    {

        fuelPrice = fuelPrice - (fuelPrice * 0.10);
        
    }
    else if (fuelType == "Diesel")
    {

        fuelPrice = fuelPrice - (fuelPrice * 0.10);
        
    }
    else if (fuelType == "Gas")
    {

        fuelPrice = fuelPrice - (fuelPrice * 0.10);
        
    }
}
else if (fuelAmount >= 20 && fuelAmount <= 25)
{
    if (fuelType == "Gasoline")
    {

        fuelPrice = fuelPrice - (fuelPrice * 0.08);
        
    }
    else if (fuelType == "Diesel")
    {

        fuelPrice = fuelPrice - (fuelPrice * 0.08);
        
    }
    else if (fuelType == "Gas")
    {

        fuelPrice = fuelPrice - (fuelPrice * 0.08);
        
    }
}


Console.WriteLine($"{fuelPrice:F2} lv.");