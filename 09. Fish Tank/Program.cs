namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double occupiedSpace = double.Parse(Console.ReadLine());

            double volumeFuelTank = length * width * hight;
            double volumeWater = volumeFuelTank * 0.001;
            double totalVolumeWater = volumeWater - (volumeWater * (occupiedSpace / 100));
            Console.WriteLine(totalVolumeWater);


        }
    }
}