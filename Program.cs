


int examHour = int.Parse(Console.ReadLine());
int examMinute = int.Parse(Console.ReadLine());
int arriveTime = int.Parse(Console.ReadLine());
int arriveMinute = int.Parse(Console.ReadLine());

int examTotalTime = examHour * 60 + examMinute;
int arriveTotalTime = arriveTime * 60 + arriveMinute;

int totalDifference = arriveTotalTime - examTotalTime;

if (totalDifference > 0)
{
    Console.WriteLine("late");
    if (totalDifference < 60)
    {
        Console.WriteLine($"{totalDifference} minutes after the start");
    }
    else if (totalDifference % 60 <= 9)
    {
        Console.WriteLine($"{totalDifference / 60}:0{totalDifference % 60} hours after the start");
    }

    else
    {
        Console.WriteLine($"{totalDifference / 60}:{totalDifference % 60} hours after the start");

    }

}
else if (totalDifference >= -30)
{
    if (totalDifference == 0)
    {
        Console.WriteLine("on time");
    }
    else
    {
        Console.WriteLine("on time");
        Console.WriteLine($"{Math.Abs(totalDifference)} minutes before the start");
    }

}
else
{
    Console.WriteLine("early");
    if (totalDifference <= -60)
    {
        if (totalDifference % 60 >= -9)
        {
            Console.WriteLine($"{Math.Abs(totalDifference / 60)}:0{Math.Abs(totalDifference % 60)} hours before the start");
        }
        else
        {
            Console.WriteLine($"{Math.Abs(totalDifference / 60)}:{Math.Abs(totalDifference % 60)} hours before the start");
        }
    }
    else
    {
        Console.WriteLine($"{Math.Abs(totalDifference)} minutes before the start");
    }
}
