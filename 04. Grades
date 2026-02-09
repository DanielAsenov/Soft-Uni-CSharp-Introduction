/*
10
3.00
2.99
5.68
3.01
4
4
6.00
4.50
2.44
5

6
2
3
4
5
6
2.2

 */


int numberOfStudents = int.Parse(Console.ReadLine());

double firstCount = 0; // 2.00 - 2.99 students
double secondCount = 0; // 3.00 - 3.99 students
double thirdCount = 0; // 4.00 - 4.99 students
double fourthCount = 0; // >= 5.00 students
double averageGrade = 0;


for (int i = 0; i < numberOfStudents; i++)
{
    double gradeStudent = double.Parse(Console.ReadLine());

    if (gradeStudent <= 2.99)
    {
        firstCount++;
        averageGrade += gradeStudent;
    }
    else if (gradeStudent <= 3.99)
    {
        secondCount++;
        averageGrade += gradeStudent;
    }
    else if (gradeStudent <= 4.99)
    {
        thirdCount++;
        averageGrade += gradeStudent;
    }
    else
    {
        fourthCount++;
        averageGrade += gradeStudent;
    }
}

Console.WriteLine($"Top students: {fourthCount/numberOfStudents * 100:F2}%");
Console.WriteLine($"Between 4.00 and 4.99: {thirdCount/numberOfStudents * 100:F2}%");
Console.WriteLine($"Between 3.00 and 3.99: {secondCount/numberOfStudents * 100:F2}%");
Console.WriteLine($"Fail: {firstCount/numberOfStudents * 100:F2}%");
Console.WriteLine($"Average: {averageGrade/numberOfStudents:F2}");
