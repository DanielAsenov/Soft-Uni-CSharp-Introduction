
/*
2
53
65
55
End

1
10
15
10
12
13
30


 */
int cleaningBottles = int.Parse(Console.ReadLine());

int cleaningAgentQuantity = cleaningBottles * 750;

int plate = 5;
int pan = 15;

int cleanPlate = 0;
int cleanPan = 0;
int cleaningNeeded = 0;
int loadCount = 0;
int canClean = 0;
int cleaningMissing = 0;
string input = "";

while ((input = Console.ReadLine()) != "End" && cleaningAgentQuantity >= 0)
{

    int quantity = int.Parse(input);
    loadCount++;



    if (loadCount % 3 == 0)
    {
        cleaningNeeded = quantity * pan;
        if (cleaningAgentQuantity >= cleaningNeeded)
        {
            cleaningAgentQuantity -= cleaningNeeded;
            cleanPan += quantity;
        }
        else
        {
            cleanPan += cleaningAgentQuantity / pan;
            cleaningMissing = cleaningNeeded - cleaningAgentQuantity;
            cleaningAgentQuantity = 0;

            break;

        }
    }
    else
    {
        cleaningNeeded = quantity * plate;
        if (cleaningAgentQuantity >= cleaningNeeded)
        {
            cleaningAgentQuantity -= cleaningNeeded;
            cleanPlate += quantity;
        }
        else
        {
            cleanPlate += cleaningAgentQuantity / plate;
            cleaningMissing = cleaningNeeded - cleaningAgentQuantity;
            cleaningAgentQuantity = 0;

            break;
        }
    }

}

if (input == "End")
{
    Console.WriteLine("Detergent was enough!");
    Console.WriteLine($"{cleanPlate} dishes and {cleanPan} pots were washed.");
    Console.WriteLine($"Leftover detergent {cleaningAgentQuantity} ml.");
}
else
{
    Console.WriteLine($"Not enough detergent, {cleaningMissing} ml. more necessary!");
}
