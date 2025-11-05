using Homework2Lib;
using System;
using static Homework2.Product;

namespace Homework2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1 argument - currency, 2 - integer part, 3 - pennies
            Money money = new(CURR.UAH, 10, 50);
            money.PrintAmount(); // 10.50 UAH
            money.SetAmount("20.1");
            money.PrintAmount(); // 20.10 UAH

            Money money2 = new(CURR.EUR, 1000, 99);
            Money money3 = new(CURR.EUR, 1000, 99);
            Console.WriteLine(money2.Equals(money3)); //True

            Money money4 = new(CURR.USD, 2225, 15);
            Console.WriteLine(money3.Equals(money4)); //False

            Product product = new("SmartTV", new MoneyArgs(CURR.UAH, 10000, 50));
            product.IncreasePrice("1000.55");
            product.Price.PrintAmount(); // Результат: 11001.05 UAH

            Product product2 = new("Smartphone", new MoneyArgs(CURR.UAH, 7500, 60));
            product2.DecreasePrice("7500.50");
            product2.Price.PrintAmount(); // Результат: 0.10 UAH

            Product product3 = new("Smartphone", new MoneyArgs(CURR.UAH, 8000, 60));
            product3.DecreasePrice("7000.70");
            product3.Price.PrintAmount(); // Результат: 999.90 UAH*/

            Console.WriteLine();

            List<MusicalInstrument> orchestra = new List<MusicalInstrument>();

            string vioDescr = "A small, four-stringed instrument played with a bow, known for its bright, expressive tone." +
                "It is widely used in classical, folk, and modern music.";
            string vioHistory = "The violin emerged in 16th-century Italy, evolving from earlier bowed instruments like the rebec." +
                "By the Baroque period, it became central to European classical music and orchestras.";
            Violin violin = new("Violin", vioDescr, vioHistory);

            string tromboneDescr = "A brass instrument with a telescoping slide that changes pitch." +
                "It produces a rich, powerful sound used in orchestras, jazz, and marching bands.";
            string tromboneHistory = "Originating in the 15th century as the “sackbut,” the trombone was used in early church and court music." +
                "It later gained prominence in symphonic and jazz ensembles.";
            Trombone trombone = new("Trombone", tromboneDescr, tromboneHistory);

            string ukuleleDescr = "A small, four-stringed instrument from Hawaii with a bright, cheerful tone." +
                "It is easy to learn and popular in folk and pop music.";
            string ukuleleHistory = "The ukulele was developed in late 19th-century Hawaii, adapted from Portuguese string instruments brought by immigrants." +
                "It quickly became a symbol of Hawaiian music and spread worldwide in the 20th century.";
            Ukulele ukulele = new("Ukulele", ukuleleDescr, ukuleleHistory);

            string celloDescr = "A large, low-pitched string instrument played with a bow while seated." +
                "It offers a warm, deep sound central to orchestras and chamber music.";
            string celloHistory = "The cello was created in 16th-century Italy as part of the violin family." +
                "It evolved from larger bass viols to become a key instrument in orchestral and solo repertoire.";
            Cello cello = new("Cello", celloDescr, celloHistory);

            orchestra.Add(violin);
            orchestra.Add(trombone);
            orchestra.Add(ukulele);
            orchestra.Add(cello);

            foreach (var instrument in orchestra)
            {
                instrument.Show();
                instrument.Desc();
                instrument.History();
            }

            DecimalNumber decimalNumber = new DecimalNumber(255);
            Console.WriteLine(decimalNumber.ToBinary());
            Console.WriteLine(decimalNumber.ToOctal());
            Console.WriteLine(decimalNumber.ToHex());
        }
    }
}