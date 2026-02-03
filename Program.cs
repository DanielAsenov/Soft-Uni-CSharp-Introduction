/*
5
1400
F
SF
W
W
SF

4
750
SF
W
SF
W

 */
int numberOfTournaments = int.Parse(Console.ReadLine());
int startPoints  = int.Parse(Console.ReadLine());


int pointsFromTournament = 0;
double tournamentsWon = 0;

for (int i = 0; i < numberOfTournaments; i++)
{
    string tournamentResult = Console.ReadLine();

    if (tournamentResult == "W")
    {
        pointsFromTournament += 2000;
        tournamentsWon++;
    }
    else if (tournamentResult == "F")
    {
        pointsFromTournament += 1200;
    }
    else if (tournamentResult == "SF")
    {
        pointsFromTournament += 720;
    }
}
double totalPoints = startPoints + pointsFromTournament;
double averagePointsPerTournament =  pointsFromTournament / numberOfTournaments;

Console.WriteLine($"Final points: {totalPoints}");
Console.WriteLine($"Average points: {Math.Floor(averagePointsPerTournament)}");
Console.WriteLine($"{tournamentsWon / numberOfTournaments * 100:F2}%");