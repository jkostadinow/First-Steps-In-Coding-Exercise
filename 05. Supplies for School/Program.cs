namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packageOfStylos = int.Parse(Console.ReadLine());
            int packageOfMarkers = int.Parse(Console.ReadLine());
            int litersOfDetergent = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double totalPriceStylos = packageOfStylos * 5.80;
            double totalPriceMarkers = packageOfMarkers * 7.20;
            double totalPriceDetergent = litersOfDetergent * 1.20;

            double costsForMaterials = totalPriceStylos + totalPriceMarkers + totalPriceDetergent;
            double totalSum = costsForMaterials - (costsForMaterials * (discount / 100.00));
            Console.WriteLine(totalSum);
        }
    }
}