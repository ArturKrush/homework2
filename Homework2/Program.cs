using System;

namespace Homework2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Money money = new(CURR.UAH, 10, 50);
            money.PrintAmount();
            money.SetAmount("20.1");
            money.PrintAmount();

            Money money2 = new(CURR.EUR, 1000, 99);
            Money money3 = new(CURR.EUR, 1000, 99);
            Console.WriteLine(money2.Equals(money3)); //true

            Money money4 = new(CURR.USD, 2225, 15);
            Console.WriteLine(money3.Equals(money4)); //false
        }
    }
}