

string fuelType = Console.ReadLine();
double fuelCapacity = double.Parse(Console.ReadLine());

if (fuelType != "Diesel" &&  fuelType != "Gasoline" && fuelType != "Gas")
{
    Console.WriteLine("Invalid fuel!");
}
else if (fuelCapacity < 25)
{
    Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
}
else
{
    Console.WriteLine($"You have enough {fuelType.ToLower()}.");
}   