int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());
minutes = minutes + 15;

int realHours = hours + minutes / 60;
int realMinutes = minutes % 60;


 if (realHours >= 24)
{
    realHours = 0;
}


    if (realMinutes < 10)
{
    Console.WriteLine($"{realHours}:0{realMinutes}");
}
 else 
    {

    Console.WriteLine($"{realHours}:{realMinutes}");
}
    

    


