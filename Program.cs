


using System.Xml;

double moneyInhertited = double.Parse(Console.ReadLine());
int yearLimit  = int.Parse(Console.ReadLine());

double expenses = 0;
int birthdayAge = 18;

for  (int i = 1800;  i <= yearLimit; i++)
{
    if (i %2  == 0)
    {
        
        moneyInhertited -= 12000;
        birthdayAge++;
    }
    else
    {
        
        moneyInhertited -= 12000 + (50 * birthdayAge);
        birthdayAge++;

    }
}


if (moneyInhertited >= 0)
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {moneyInhertited:F2} dollars left.");
}
else
{
    Console.WriteLine($"He will need {Math.Abs(moneyInhertited):F2} dollars to survive.");
}