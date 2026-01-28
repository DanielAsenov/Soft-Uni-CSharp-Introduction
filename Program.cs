



int pageCount = int.Parse(Console.ReadLine());
int pages  = int.Parse(Console.ReadLine());
int days  = int.Parse(Console.ReadLine());

int hoursAll = pageCount / pages;
int hoursDay = hoursAll / days;

Console.WriteLine(hoursDay);