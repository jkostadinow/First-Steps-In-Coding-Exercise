﻿namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine());

            double sum = deposit + term * ((deposit * (rate / 100)) / 12);
            Console.WriteLine(sum);
        }
    }
}