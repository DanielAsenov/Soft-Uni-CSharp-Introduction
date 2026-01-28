/*
 
2
3
5
1
50



15
7
5
10
100
 
 
 
 
 
 */


int mangolyCount = int.Parse(Console.ReadLine());
int zumbulCount = int.Parse(Console.ReadLine());
int rosesCount = int.Parse(Console.ReadLine());
int cactusesCount = int.Parse(Console.ReadLine());
double giftPrice = double.Parse(Console.ReadLine());


double mangolyPrice = mangolyCount * 3.25;
double zumbulPrice = zumbulCount * 4;
double rosesPrice = rosesCount * 3.50;
double cactusesPrice = cactusesCount * 8;

double total = mangolyPrice + zumbulPrice + rosesPrice + cactusesPrice;
double taxesPrice = total * 0.05;
double totalLeft = total - taxesPrice;

if (totalLeft >= giftPrice)
{
    Console.WriteLine($"She is left with {Math.Floor(totalLeft - giftPrice)} leva.");
}
else
{
    Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - totalLeft)} leva.");
}

