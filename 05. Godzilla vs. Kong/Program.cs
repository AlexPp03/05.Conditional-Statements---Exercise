double budget = double.Parse(Console.ReadLine());
int extra = int.Parse(Console.ReadLine());
double priceForOneExtra = double.Parse(Console.ReadLine());

double decor = budget * 0.10;
double priceForClothes = priceForOneExtra * extra;


if (extra > 150)
{
    priceForClothes = priceForClothes - priceForClothes * 0.10;

}

double sum = decor + priceForClothes;

if (sum > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {sum - budget:f2} leva more.");
}
else if (sum <= budget)
{
    Console.WriteLine("Action!"); 
    Console.WriteLine($"Wingard starts filming with {budget - sum :f2} leva left.");
}