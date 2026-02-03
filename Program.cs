
int age = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int toyPrice  = int.Parse(Console.ReadLine());

int toyCount = 0;
int moneySaved = 0;
int moneyPerEvenBirthday = 10;


for (int i = 1;  i <= age; i++)
{
    if (i % 2 == 0)
    {
        moneySaved += moneyPerEvenBirthday - 1;
        moneyPerEvenBirthday += 10;
    }
    else
    {
        toyCount++;
    }
}

int totalMoneySaved = moneySaved + (toyCount * toyPrice);

if (totalMoneySaved >= washingMachinePrice)
{
    Console.WriteLine($"Yes! {totalMoneySaved - washingMachinePrice:F2}");
}
else
{
    Console.WriteLine($"No! {washingMachinePrice-totalMoneySaved:F2}");
}