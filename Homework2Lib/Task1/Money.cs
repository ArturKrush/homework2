using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace Homework2
{
    public enum CURR
    {
        USD,
        EUR,
        UAH
    }

    public class Money
    {
        private int integerPart;
        private int pennies;

        public Money(CURR currency, int integerPart, int pennies)
        {
            Currency = currency;
            IntegerPart = integerPart;
            Pennies = pennies;
        }

        public int IntegerPart
        {
            private set
            {
                if (value < 0 || value >= int.MaxValue)
                    throw new InvalidDataException("Integer part can not be negative or so large");
                integerPart = value;
            }
            get { return integerPart; }
        }

        public int Pennies
        {
            private set
            {
                if (value < 0 || value > 99)
                    throw new InvalidDataException("Pennies number must be in range from 1 to 99");
                pennies = value;
            }
            get { return pennies; }
        }

        public CURR Currency
        {
            private set;
            get;
        }

        /*public double Amount
        {
            get { return integerPart + (double)pennies / 100; }
            private set { }
        }*/

        public void PrintAmount()
        {
            string result = (IntegerPart + ((double)Pennies / 100)).ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(result + " " + Currency.ToString());
        }

        public void SetAmount(string input)
        {
            // Дозволяємо лише формат: ціле додатне число, можливо крапка + 1–2 цифри після неї
            Regex regex = new Regex(@"^\d+(\.\d{1,2})?$");

            if (!regex.IsMatch(input))
                throw new InvalidDataException("Invalid money format." +
                    "Must be a positive number with up to two decimal digits, using a dot as separator.");

            // Ділимо рядок за крапкою на цілу частину та копійки
            string[] parts = input.Split('.');
            int intPart = int.Parse(parts[0]);
            int penniesPart = 0;

            if (parts.Length == 2)
            {
                string p = parts[1].PadRight(2, '0'); // якщо одна цифра — додає 0 праворуч
                penniesPart = int.Parse(p);
            }

            // Використовуємо властивості — вони самі виконують перевірки
            IntegerPart = intPart;
            Pennies = penniesPart;
        }

        public override int GetHashCode() => HashCode.Combine(Currency, IntegerPart, Pennies);

        public override bool Equals(object? obj)
        {
            if (obj is Money m)
                return m.Currency == Currency && m.IntegerPart == IntegerPart && m.Pennies == Pennies;
            return false;
        }
    }
}
