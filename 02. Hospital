

int periodOfTime = int.Parse(Console.ReadLine());


int doctorsAvailable = 7;
int patientsChecked = 0;
int patientsUnchecked = 0;
int patientsTotal = 0;


for  (int i = 1; i <= periodOfTime; i++)
{

    if (i % 3 == 0)
    {
        if (patientsUnchecked > patientsChecked)
        {
            doctorsAvailable++;
        }

    }


    int patients = int.Parse(Console.ReadLine());

   


    if (patients <= doctorsAvailable)
    {
        patientsChecked += patients;
    }
    else if (patients > doctorsAvailable)
    {
        patientsChecked += doctorsAvailable;
        patientsUnchecked += patients - doctorsAvailable;
    }
}

Console.WriteLine($"Treated patients: {patientsChecked}.");
Console.WriteLine($"Untreated patients: {patientsUnchecked}.");
