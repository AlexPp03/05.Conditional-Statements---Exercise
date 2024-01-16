double priceForTrip = double.Parse(Console.ReadLine());
int puzzle = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int bears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int truck = int.Parse(Console.ReadLine());

double pricePuzzle = puzzle * 2.60;
double priceDolls = dolls * 3;
double priceBears = bears * 4.10;
double priceMinions = minions * 8.20;
double priceTruck = truck * 2;

double sum = pricePuzzle + priceDolls + priceBears + priceMinions + priceTruck;
int countOfToys = puzzle + dolls + bears + minions + truck;

if (countOfToys >= 50)
{
    sum = sum - sum * 0.25;
}

double rent = sum * 0.10;
double finalIncome = sum - rent;

if (finalIncome >= priceForTrip)
{
    Console.WriteLine($"Yes! {finalIncome - priceForTrip:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {priceForTrip - finalIncome:f2} lv needed.");
}