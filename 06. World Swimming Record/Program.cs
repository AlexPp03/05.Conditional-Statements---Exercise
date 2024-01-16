double recordInSeconds = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double oneMeterInSeconds = double.Parse(Console.ReadLine());

double timeNeeded = distanceInMeters * oneMeterInSeconds;
double delay = Math.Floor(distanceInMeters  / 15);
double finalTime = timeNeeded + (delay * 12.5);

if (finalTime < recordInSeconds)
{
    
    Console.WriteLine($" Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
}

else
{
    Console.WriteLine($"No, he failed! He was {finalTime - recordInSeconds:f2} seconds slower.");
}

    

