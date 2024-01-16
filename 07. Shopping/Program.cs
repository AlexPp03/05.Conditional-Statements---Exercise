double budged = double.Parse(Console.ReadLine());
int videoCard = int.Parse(Console.ReadLine());
int processor = int.Parse(Console.ReadLine());
int ramMemmory = int.Parse(Console.ReadLine());

double priceForVideoCard = videoCard * 250;
double priceForProcessor =  (priceForVideoCard  * 0.35) * processor;
double priceForRamMemmory = (priceForVideoCard   * 0.10) * ramMemmory;

double finalPrice = priceForVideoCard + priceForProcessor + priceForRamMemmory;


if (videoCard > processor)
{
    finalPrice = finalPrice - finalPrice * 0.15;
}

if (budged >= finalPrice )
{
    Console.WriteLine($"You have {budged - finalPrice:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {finalPrice - budged:f2} leva more!");
}
