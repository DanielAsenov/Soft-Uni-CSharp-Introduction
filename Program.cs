/*
76
10
A
V
V
V
G
B
A
V
B
B

*/

int capacity = int.Parse(Console.ReadLine());
int numberOfFans = int.Parse(Console.ReadLine());

double sectorA = 0;
double sectorB = 0;
double sectorV = 0;
double sectorG = 0;


for (int i = 0; i < numberOfFans; i++)
{
    string sector = Console.ReadLine();

    if (sector == "A")
    {
        sectorA++;
    }
    else if (sector == "B")
    {
        sectorB++;
    }
    else if (sector == "V")
    {
        sectorV++;
    }
    else if (sector == "G")
    {
        sectorG++;
    }
}

Console.WriteLine($"{sectorA / numberOfFans * 100:F2}");
Console.WriteLine($"{sectorB / numberOfFans * 100:F2}");
Console.WriteLine($"{sectorV / numberOfFans * 100:F2}");
Console.WriteLine($"{sectorG / numberOfFans * 100:F2}");
Console.WriteLine($"{(double)numberOfFans / capacity * 100:F2}");
