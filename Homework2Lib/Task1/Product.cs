using System;
using System.Text.RegularExpressions;

namespace Homework2
{
    public class Product
    {
        public static Regex productRegex = new Regex(@"^[A-Za-z][A-Za-z0-9,-]*$");

        private string name;
        public string Name
        {
            get { return name; }
            private set
            {
                if (!productRegex.IsMatch(value))
                    throw new InvalidDataException("Invalid product name format.");
                name = value;
            }
        }

        public Money Price
        {
            get;
            private set;
        }

        public record struct MoneyArgs(CURR Currency, int Integer, int Pennies);

        public Product(string name, MoneyArgs args)
        {
            Name = name;
            Price = new Money(args.Currency, args.Integer, args.Pennies); ;
        }

        public void IncreasePrice(string input)
        {
            // Формат грошей перевіряється відповідно до шаблону
            Money.CheckAmount(input);

            string[] parts = input.Split('.');
            int intPart = int.Parse(parts[0]);
            int pennPart = int.Parse(parts[1]);

            int intRes = Price.IntegerPart + intPart;
            int pennRes = 0;
            if (Price.Pennies + pennPart >= 100)
            {
                intRes++;
                pennRes = pennPart + Price.Pennies - 100;
            }
            else
            {
                pennRes = pennPart + Price.Pennies;
            }

            string result = (intRes + ((double)pennRes / 100)).ToString("F2",
                System.Globalization.CultureInfo.InvariantCulture);

            Price.SetAmount(result);
        }

        public void DecreasePrice(string input)
        {
            // Формат грошей перевіряється відповідно до шаблону
            Money.CheckAmount(input);

            string[] parts = input.Split('.');
            int intPart = int.Parse(parts[0]);
            int pennPart = int.Parse(parts[1]);

            if (Price.IntegerPart - intPart < 0)
                throw new InvalidDataException("Price received after decreasing less than 0");

            int intRes = Price.IntegerPart - intPart;
            int pennRes = 0;

            if (Price.Pennies - pennPart < 0)
            {
                if(intRes == 0)
                    throw new InvalidDataException("Price received after decreasing less than 0");

                intRes--;
                pennRes = 100 + (Price.Pennies - pennPart);
            }
            else
            {
                pennRes = Price.Pennies - pennPart;
            }

            string result = (intRes + ((double)pennRes / 100)).ToString("F2",
                System.Globalization.CultureInfo.InvariantCulture);

            Price.SetAmount(result);
        }
    }
}