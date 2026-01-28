









int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double nylonPrice = (nylon + 2) * 1.50;
double paintPrice = paint * 14.50 + (paint * 14.50 / 10);
double thinnerPrice = thinner * 5.00;
double bagsPrice = 0.40;

double cost = nylonPrice + paintPrice + thinnerPrice + bagsPrice;
double hoursLabour = (cost * 0.30) * hours;
double finalPrice = cost + hoursLabour;

Console.WriteLine(finalPrice);

