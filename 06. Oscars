/*
Zahari Baharov
205
4
Johnny Depp
45
Will Smith
29
Jet Lee
10
Matthew Mcconaughey
39


Sandra Bullock
340
5
Robert De Niro
50
Julia Roberts
40.5
Daniel Day-Lewis
39.4
Nicolas Cage
29.9
Stoyanka Mutafova
33

 */

string actorName = Console.ReadLine();
double academyPoints = double.Parse(Console.ReadLine());
int numberOfEvaluations = int.Parse(Console.ReadLine());


double totalScore = academyPoints + 0;

for (int i = 1; i <= numberOfEvaluations; i++)
{


    string judge = Console.ReadLine();
    double points = double.Parse(Console.ReadLine());
    double judgeNamePoints = judge.Length;
    double total = judgeNamePoints * points / 2;
    totalScore += total;
    if (totalScore > 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalScore:F1}!");
        break;
    }
    

}
if (totalScore < 1250.5)
{
    Console.WriteLine($"Sorry, {actorName} you need {1250.5 - totalScore:F1} more!");
}

