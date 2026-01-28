










int chickenMenus = int.Parse(Console.ReadLine());
int fishMenus = int.Parse(Console.ReadLine());
int veganMenus = int.Parse(Console.ReadLine());

double chickenPrice = chickenMenus * 10.35;
double fishPrice = fishMenus * 12.40;
double veganPrice = veganMenus * 8.15;
double deliveryPrice = 2.50;

double price = chickenPrice + fishPrice + veganPrice;

double dessert = price * 0.2;

double finalPrice = price + dessert + deliveryPrice;




Console.WriteLine(finalPrice);