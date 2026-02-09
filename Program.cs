


int loads = int.Parse(Console.ReadLine());

int tonsOfLoads = 0;
double price = 0;
double averageLoad = 0;
double busLoad = 0;
double truckLoad = 0;
double trainLoad = 0;



for (int i = 0; i < loads; i++)
{
    int loadKG = int.Parse(Console.ReadLine());
    tonsOfLoads += loadKG;

    if (loadKG <= 3)
    {
        price += loadKG * 200;
        busLoad += loadKG;
    }
    else if (loadKG >= 4 && loadKG <= 11)
    {
        price += loadKG * 175;
        truckLoad += loadKG;
    }
    else if (loadKG >= 12)
    {
        price += loadKG * 120;
        trainLoad += loadKG;    
    }

    averageLoad = price / tonsOfLoads;

}
Console.WriteLine($"{averageLoad:F2}");
Console.WriteLine($"{busLoad/tonsOfLoads * 100}%");
Console.WriteLine($"{truckLoad / tonsOfLoads * 100}%");
Console.WriteLine($"{trainLoad / tonsOfLoads * 100}%");
