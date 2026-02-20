


string championshipStage = Console.ReadLine();
string ticketName = Console.ReadLine();
int numberOfTickets = int.Parse(Console.ReadLine());
string pictureWithTrophey = Console.ReadLine();

double ticketsPrice = 0;
double picturePrice = 0;


// stages price
if (championshipStage == "Quarter final")
{
    if (ticketName == "Standard")
    {
        ticketsPrice = numberOfTickets * 55.50;
    }
    if (ticketName == "Premium")
    {
        ticketsPrice = numberOfTickets * 105.20;
    }
    if (ticketName == "VIP")
    {
        ticketsPrice = numberOfTickets * 118.90;
    }
}
// stages price
if (championshipStage == "Semi final")
{
    if (ticketName == "Standard")
    {
        ticketsPrice = numberOfTickets * 75.88;
    }
    if (ticketName == "Premium")
    {
        ticketsPrice = numberOfTickets * 125.22;
    }
    if (ticketName == "VIP")
    {
        ticketsPrice = numberOfTickets * 300.40;
    }
}
// stages price
if (championshipStage == "Final")
{
    if (ticketName == "Standard")
    {
        ticketsPrice = numberOfTickets * 110.10;
    }
    if (ticketName == "Premium")
    {
        ticketsPrice = numberOfTickets * 160.66;
    }
    if (ticketName == "VIP")
    {
        ticketsPrice = numberOfTickets * 400;
    }
}

// discounts and picture

if (ticketsPrice > 4000)
{
    if (pictureWithTrophey == "Y")
    {
        picturePrice = 0;
        ticketsPrice = ticketsPrice * 0.75;

    }
    else
    {
        ticketsPrice = ticketsPrice * 0.75;
    }
}
else if (ticketsPrice > 2500)
{
    ticketsPrice = ticketsPrice * 0.90;

    if (pictureWithTrophey == "Y")
    {
        ticketsPrice = ticketsPrice + (numberOfTickets * 40);
        
    } 

}
else
{
    if (pictureWithTrophey == "Y")
    {
        ticketsPrice = ticketsPrice + (numberOfTickets * 40);
    }
}


    Console.WriteLine($"{ticketsPrice:F2}");