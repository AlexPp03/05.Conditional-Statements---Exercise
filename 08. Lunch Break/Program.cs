string name = Console.ReadLine();
int timeOfEpisode = int.Parse(Console.ReadLine());
int restTime = int.Parse(Console.ReadLine());

double lunchTime = restTime / 8.0;
double timeRest = restTime / 4.0;
double fullRest = lunchTime + timeRest;
double timeleft = restTime - fullRest;

if (timeleft >= timeOfEpisode)
{
    Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeleft - timeOfEpisode)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(timeOfEpisode - timeleft)} more minutes.");
}