







double vegetablePricePerKg = double.Parse(Console.ReadLine());
double fruitKgPricePerKg = double.Parse(Console.ReadLine()); 
int vegetableKg = int.Parse(Console.ReadLine());
int fruitKg =   int.Parse(Console.ReadLine());

double vegetablePrice = vegetablePricePerKg * vegetableKg;
double fruitPrice = fruitKgPricePerKg * fruitKg;

double sum = vegetablePrice + fruitPrice;

double convertSum = sum / 1.94;

Console.WriteLine($"{convertSum:f2}");