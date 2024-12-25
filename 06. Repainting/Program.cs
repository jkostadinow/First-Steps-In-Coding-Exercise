namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylonQuantity = int.Parse(Console.ReadLine());
            int paintLiters = int.Parse(Console.ReadLine());
            int thinnerLiters = int.Parse(Console.ReadLine());
            int workingTime = int.Parse(Console.ReadLine());

            double nylonPrice = (nylonQuantity + 2) * 1.5;
            double paintPrice = (paintLiters + paintLiters * 0.1) * 14.50;
            double thinnerPrice = thinnerLiters * 5;

            double materialsSum = nylonPrice + paintPrice + thinnerPrice + 0.40;
            double workersSum = materialsSum * 0.30 * workingTime;
            double totalSum = materialsSum + workersSum;
            Console.WriteLine(totalSum);

        }
    }
}