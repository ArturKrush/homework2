using System;

namespace Homework2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1 argument - currency, 2 - integer part, 3 - pennies
            /*
            Money money = new(CURR.UAH, 10, 50);
            money.PrintAmount();
            money.SetAmount("20.1");
            money.PrintAmount();

            Money money2 = new(CURR.EUR, 1000, 99);
            Money money3 = new(CURR.EUR, 1000, 99);
            Console.WriteLine(money2.Equals(money3)); //True

            Money money4 = new(CURR.USD, 2225, 15);
            Console.WriteLine(money3.Equals(money4)); //False
            */

            Product product = new("SmartTV", CURR.UAH, 10000, 50);
            product.IncreasePrice("1000.55");
            product.Price.PrintAmount(); // Результат: 11001.05 UAH

            Product product2 = new("Smartphone", CURR.UAH, 7500, 60);
            product2.DecreasePrice("7500.50");
            product2.Price.PrintAmount(); // Результат: 0.10 UAH

            Product product3 = new("Smartphone", CURR.UAH, 8000, 60);
            product3.DecreasePrice("7000.70");
            product3.Price.PrintAmount(); // Результат: 0.10 UAH
        }
    }
}