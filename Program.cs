

/*
3
Money
6
Story
4
Spring Time
5
Bus
6
Enough

2
Income
3
Game Info
6
Best Player
4

 */
using System.Runtime.CompilerServices;

int inefficientGrades = int.Parse(Console.ReadLine());

string taskName = Console.ReadLine();
int grade = int.Parse(Console.ReadLine());

double averageGrade = 0;
int poorGrades = 0;
int tasksSolved = 0;
string lastProblem = "";



while (taskName != "Enough" || poorGrades >= inefficientGrades)
{
    averageGrade += grade;
    tasksSolved++;

    if (grade <= 4)
    {
        poorGrades++;
        if (poorGrades == inefficientGrades)
        {
            Console.WriteLine($"You need a break, {poorGrades} poor grades.");
            break;
        }
    }

    taskName = Console.ReadLine();
    if (taskName == "Enough")
    {
        Console.WriteLine($"Average score: {averageGrade / tasksSolved:F2}");
        Console.WriteLine($"Number of problems: {tasksSolved}");
        Console.WriteLine($"Last problem: {lastProblem}");
        break;
    }
    if (taskName != "Enouhg")
    {
        lastProblem = taskName;
    }
    grade = int.Parse(Console.ReadLine());
    

}

