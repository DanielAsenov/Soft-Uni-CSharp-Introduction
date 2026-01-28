


using Microsoft.VisualBasic;

double age = double.Parse(Console.ReadLine());
string sex = Console.ReadLine();

if (age < 16 && sex == "m")
{
    Console.WriteLine("Master");
}
else if (age>=16 && sex == "m")
{
    Console.WriteLine("Mr.");
}


if (age < 16 && sex == "f")
{
    Console.WriteLine("Miss");
}
else if (age >= 16 && sex == "f")
{
    Console.WriteLine("Ms.");
}