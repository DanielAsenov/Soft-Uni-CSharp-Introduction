




// Входове
using System.Threading.Channels;

double skumriqPricePerKg = double.Parse(Console.ReadLine());
double cacaPricePerKg = double.Parse(Console.ReadLine());
double palamudPricePerKg = double.Parse(Console.ReadLine());
double safridPricePerKg  = double.Parse(Console.ReadLine());
int midiPricePerKg = int.Parse(Console.ReadLine());


// цени на миди за 1 кг.
double musslePriceKg = midiPricePerKg * 7.50;

// цени на останалите риби

double palamudCostPerKg = skumriqPricePerKg + skumriqPricePerKg * 0.6;
double palamudPrice = palamudCostPerKg * palamudPricePerKg;

double safridCostPerKg = cacaPricePerKg + cacaPricePerKg * 0.8;
double safridPrice = safridPricePerKg    * safridCostPerKg;

// цена за всичко 

double priceAll = palamudPrice + safridPrice + musslePriceKg;

Console.WriteLine($"{priceAll:f2}");