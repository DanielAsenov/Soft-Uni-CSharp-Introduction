/*
5
68.63
89.25
132.53
93.53
63.22

8
123.54
231.54
140.23
100
122.4
430
178.52
64.2

 */

int monthsCount = int.Parse(Console.ReadLine());

double waterBill = monthsCount *20;
double internetBill = monthsCount *15;
double electiryBill = 0;



for  (int i = 0; i < monthsCount; i++)
{
    double electrictyBillMonth = double.Parse(Console.ReadLine());

    electiryBill += electrictyBillMonth;
}

double totalBills = waterBill +  internetBill + electiryBill;
double otherBills = totalBills * 1.20;

double averageBillsPerMonth = (totalBills + otherBills) / monthsCount;

Console.WriteLine($"Electricity: {electiryBill:F2} lv");
Console.WriteLine($"Water: {waterBill:F2} lv");
Console.WriteLine($"Internet: {internetBill:F2} lv");
Console.WriteLine($"Other: {otherBills:F2} lv");
Console.WriteLine($"Average: {averageBillsPerMonth:F2} lv");