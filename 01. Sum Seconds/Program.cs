int firstTime = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

int time = firstTime + secondTime + thirdTime;

double minutes = time / 60;
double seconds = time % 60;

if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");

}
else

Console.WriteLine($"{minutes}:{seconds}");