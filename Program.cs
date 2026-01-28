

string dayOfWeek = Console.ReadLine();

int priceOfTicket = 0;

if (dayOfWeek == "Monday" ||  dayOfWeek == "Tuesday" || dayOfWeek == "Friday")
{
    priceOfTicket = 12;
    Console.WriteLine(priceOfTicket);
}
else if (dayOfWeek == "Wednesday" || dayOfWeek == "Thursday")
{
    priceOfTicket = 14;
    Console.WriteLine(priceOfTicket);
}
else
{
    priceOfTicket = 16;
    Console.WriteLine(priceOfTicket);
}