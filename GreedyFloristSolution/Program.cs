internal class Program
{
    private static void Main(string[] args)
    {
        var numberOfFriends = Convert.ToInt32(Console.ReadLine());
        var numberOfFlowers = Convert.ToInt32(Console.ReadLine());

        var flowersPrices = new List<int>();
        for (int i = 0; i < numberOfFlowers; i++)
            flowersPrices.Add(Convert.ToInt32(Console.ReadLine()));

        flowersPrices = flowersPrices.OrderByDescending(x => x).ToList();
        var totalCost = 0;
        for (int i = 0; i < numberOfFlowers; i++)
            totalCost += (i / numberOfFriends + 1) * flowersPrices[i];

        Console.WriteLine(totalCost);
    }
}