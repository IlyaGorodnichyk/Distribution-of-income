using System;

namespace Distribution_of_income
{
    class Program
    {
        static void Main(string[] args)
        {
            string summa;
            Console.Write("Enter the amount: ");
            summa = Console.ReadLine();
            Console.WriteLine(" ");
            int amount = Convert.ToInt32(summa);
            decimal tenPercent = (amount * 10m) / 100;
            decimal saving = (amount / 2m) - tenPercent;
            decimal petrol = 50m;
            decimal coupons = 30m;
            decimal phone = 40m;
            decimal doctor = 150m;
            decimal remainder = amount - tenPercent - saving - petrol - coupons - phone - doctor;

            Console.WriteLine($" 10 percent of income: {tenPercent}\n");
            Console.WriteLine($" Saving: {saving}\n");
            Console.WriteLine($" Petrol: {petrol}\n");
            Console.WriteLine($" Coupons: {coupons}\n");
            Console.WriteLine($" Phone: {phone}\n");
            Console.WriteLine($" Doctor: {doctor}\n");
            Console.WriteLine($" Remainder: {remainder}\n");
        }
    }
}
