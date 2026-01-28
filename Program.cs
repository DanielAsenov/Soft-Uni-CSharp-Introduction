




int priceYear = int.Parse(Console.ReadLine());

double shoePrice = priceYear - (priceYear * 0.4);
double uniformPrice = shoePrice - (shoePrice * 0.2);
double basketballPrice = uniformPrice * 0.25;
double accessoriesPrice = basketballPrice * 0.20;

double cost = priceYear + shoePrice + uniformPrice + basketballPrice + accessoriesPrice;


Console.WriteLine(cost);