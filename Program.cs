
/*
3
9
0
7
19
4
stop
 */



int primeSum = 0;
int nonPrimeSum = 0;



while (true)
{
    string input = Console.ReadLine();
    if (input == "stop") break;

    int number = int.Parse(input);

    if (number < 0)
    {
        Console.WriteLine("Number is negative.");
        continue; // skip this number
    }

    if (IsPrime(number))
        primeSum += number;
    else
        nonPrimeSum += number;
}

Console.WriteLine($"Sum of prime numbers: {primeSum}");
Console.WriteLine($"Sum of non-prime numbers: {nonPrimeSum}");

// Function to check if a number is prime
static bool IsPrime(int n)
{
    if (n <= 1) return false;

    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
            return false; // found a divisor → not prime
    }

    return true; // no divisors → prime
}
