


int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int hoursCount = 0;
int minutesCount = minutes + 15;


if (hours <= 0 || hours <= 23)
{
    hoursCount = hours;
}



if (minutesCount <= 0 || minutesCount <= 59)
{
    Console.WriteLine($"{hoursCount}:{minutesCount}");
}



else if (minutesCount > 59)
{

    hoursCount++;
    if (hoursCount >= 24)
    {
        hoursCount = hours / 24;
    }
  

        minutesCount = minutesCount % 60;

    if (minutesCount <= 9)
    {
        Console.WriteLine($"{hoursCount}:0{minutesCount}");
    }
    else
    {
        Console.WriteLine($"{hoursCount}:{minutesCount}");
    }

}

