

int startNumber = int.Parse(Console.ReadLine());
int lastNumber = int.Parse(Console.ReadLine());
int reqNumber = int.Parse(Console.ReadLine());

int combinations = 0;
bool result = false;


for (int i = startNumber; i <= lastNumber; i++)
{
    for (int j = startNumber; j <=lastNumber; j++)
    {
        combinations++;
        if (i + j == reqNumber)
        {
            Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {reqNumber})");
            result = true;
            if (result)
            {
                break;
            }
        }
        
        
    }
    if (result)
    {
        break;
    }
}

if (result == false)
{
    Console.WriteLine($"{combinations} combinations - neither equals {reqNumber}");
}