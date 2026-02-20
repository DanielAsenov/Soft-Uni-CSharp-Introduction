/*
2
While-Loop
6.00
5.50
For-Loop
5.84
5.66
Finish

3
Arrays
4.53
5.23
5.00
Lists
5.83
6.00
5.42
Finish
 */

int juryCount = int.Parse(Console.ReadLine());

string presentation = "";
double gradeForClass = 0;
double totalGrade = 0;
int gradeCount = 0;

while ((presentation = Console.ReadLine())  != "Finish")
{
    

    for (int i = 1; i <= juryCount; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        gradeForClass += grade;
        totalGrade += grade;
        gradeCount++;
        if (i == juryCount)
        {
            Console.WriteLine($"{presentation} - {gradeForClass / juryCount:F2}.");
            gradeForClass = 0;
        }
    }

    
}

if (presentation == "Finish")
{
    Console.WriteLine($"Student's final assessment is {totalGrade/gradeCount:F2}.");
}