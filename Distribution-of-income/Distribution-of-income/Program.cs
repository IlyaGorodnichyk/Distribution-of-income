using System;

namespace Distribution_of_income
{
    class Program
    {
        static void Main(string[] args)
        {
            string summa;
            Console.Write("(З/П) Enter the amount: ");
            summa = Console.ReadLine();
            decimal num;

                if (!decimal.TryParse(summa, out num))
                {
                    Console.WriteLine("You entered incorrect data");
                    return;
                }

            decimal amount = Convert.ToDecimal(summa);

            Console.WriteLine(" ");
           
            decimal tenPercent = (amount * 10m) / 100;
            decimal saving = (amount / 2m) - tenPercent;
            decimal communal = 60m;
            decimal petrol = 60m;
            decimal coupons = 30m;
            decimal phone = 40m;
            decimal doctor = 150m;
           
            decimal remainder = amount - tenPercent - saving - petrol - coupons - phone - doctor;
            decimal consumption = communal + petrol + coupons + phone + doctor;

            Console.WriteLine($" (10%) 10 percent of income:  {Math.Round(tenPercent,2) } BYR\n");
            Console.WriteLine($" (Сбережения) Saving: {Math.Round(saving, 2)} BYR\n");
            Console.WriteLine($" (Коммунальные) Communal: {communal} BYR\n");
            Console.WriteLine($" (Бензин) Petrol: {petrol} BYR\n");
            Console.WriteLine($" (Талоны) Coupons: {coupons} BYR\n");
            Console.WriteLine($" (Тел.) Phone: {phone} BYR\n");
            Console.WriteLine($" (Врач) Doctor: {doctor} BYR\n");
            Console.WriteLine($" (Общ. расход) Total expense: {consumption} BYR\n");
           
           
            if(remainder <0)
                Console.WriteLine($" (Не хватает) Lasks: {Math.Round(remainder, 2)} BYR\n");
            else
                Console.WriteLine($" (Остаток) Remainder: {Math.Round(remainder, 2)} BYR\n");
            while (true)
            Console.ReadLine();
        }
        
    }
    
}
