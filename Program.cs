



using System.Runtime.CompilerServices;

double deposit = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double interest = double.Parse(Console.ReadLine());

double interestDecimal = interest / 100;

double sum = deposit + months * ((deposit * interestDecimal) / 12);

Console.WriteLine(sum);