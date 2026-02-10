/*

Gosho
5
5.5
6
5.43
5.5
6
5.55
5
6
6
5.43

Mimi
5
6
5
6
5
6
6
2
3

 */

string studentName = Console.ReadLine();
double studentGrade = double.Parse(Console.ReadLine());

int gradeCount = 0;
double gradeAverage = 0;

while (studentGrade >= 4.00)
{
    gradeAverage += studentGrade;
    gradeCount++;

    if (gradeCount == 12)
    {
        Console.WriteLine($"{studentName} graduated. Average grade: {gradeAverage / gradeCount:F2}");
        break;
    }

    studentGrade = double.Parse(Console.ReadLine());


}

if (studentGrade < 4)
{
    gradeCount++;
    Console.WriteLine($"{studentName} has been excluded at {gradeCount} grade");
}