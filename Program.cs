


string movieType = Console.ReadLine();
int rowsCount = int.Parse(Console.ReadLine());
int columnsCount = int.Parse(Console.ReadLine());
double price = 0;

if (movieType == "Premiere")
{
    price = rowsCount * columnsCount * 12.00;
}
else if (movieType == "Normal")
{
    price = rowsCount * columnsCount * 7.50;
}
else if (movieType == "Discount")
{
    price = rowsCount * columnsCount * 5.00;
}

Console.WriteLine($"{price:F2}");