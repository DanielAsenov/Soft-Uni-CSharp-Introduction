/*
500
120
8
63
256
78
317

600
86
150
98
227
End



 */
int sumNeeded = int.Parse(Console.ReadLine());

int sumAdded = 0;
int sumTotalCreditCard = 0;
int sumTotalCash = 0;
int sumTotal = 0;
string sumDonated = "";

int creditCardCount = 0;
int cashCount = 0;
int totalCount = 0;



while (sumTotal < sumNeeded && (sumDonated = Console.ReadLine()) != "End")
{


    sumAdded = int.Parse(sumDonated);

    totalCount++;
    if (sumAdded > 100)
    {
        if (totalCount % 2 == 0)
        {
            sumTotalCreditCard += sumAdded;
            sumTotal += sumAdded;
            creditCardCount++;
            Console.WriteLine("Product sold!");
        }
        else
        {
            Console.WriteLine("Error in transaction!");
        }
    }
    else if (sumAdded < 10)
    {
        if (totalCount % 2 == 1)
        {
            sumTotalCash += sumAdded;
            sumTotal += sumAdded;
            cashCount++;
            Console.WriteLine("Product sold!");
        }
        else
        {
            Console.WriteLine("Error in transaction!");
        }
    }
    else
    {
        if (totalCount % 2 == 1)
        {
            sumTotalCash += sumAdded;
            sumTotal += sumAdded;
            cashCount++;
            Console.WriteLine("Product sold!");
        }
        else
        {
            sumTotalCreditCard += sumAdded;
            sumTotal += sumTotalCreditCard;
            creditCardCount++;
            Console.WriteLine("Product sold!");
        }

    }



}

if (sumDonated == "End")
{
    if (sumTotal < sumNeeded)
    {
        Console.WriteLine("Failed to collect required money for charity.");
    }
}
else if (sumTotal >= sumNeeded)
{
    Console.WriteLine($"Average CS: {(double)sumTotalCash / cashCount:F2}");
    Console.WriteLine($"Average CC: {(double)sumTotalCreditCard / creditCardCount:F2}");
}