namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfChickenMenues = int.Parse(Console.ReadLine());
            int numberOfFishMenues = int.Parse(Console.ReadLine());
            int numberOfVegetarianMenues = int.Parse(Console.ReadLine());

            double totalPriceOfChickenMenues = numberOfChickenMenues * 10.35;
            double totalPriceOfFishMenues = numberOfFishMenues * 12.40;
            double totalPriceOfVegetableMenues = numberOfVegetarianMenues * 8.15;

            double totalPriceOfMenues = totalPriceOfChickenMenues + totalPriceOfFishMenues + totalPriceOfVegetableMenues;
            double priceOfDesert = totalPriceOfMenues * 0.2;
            double totalSum = totalPriceOfMenues + priceOfDesert + 2.50;
            Console.WriteLine(totalSum);
        }
    }
}