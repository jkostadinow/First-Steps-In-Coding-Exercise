namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double annualTax = double.Parse(Console.ReadLine());

            double sneakers = annualTax - annualTax * 0.4;
            double sweatsuit = sneakers - sneakers * 0.2;
            double ball = sweatsuit / 4;
            double accessories = ball / 5;

            double totalCosts = annualTax + sneakers + sweatsuit + ball + accessories;
            Console.WriteLine(totalCosts);
        }
    }
}