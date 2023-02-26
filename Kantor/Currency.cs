using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kantor
{
    internal class Currency
    {
        private string currencyName;
        private double multiplier_in_PLN;
        private string currencyCode;

        public Currency(string currencyName, double multiplier_in_PLN, string currencyCode)
        {
            this.currencyName = currencyName;
            this.multiplier_in_PLN = multiplier_in_PLN;
            this.currencyCode = currencyCode;
            Service.Currencies.Add(this);
        }

        public string getName() { return currencyName; }
        public double getMultiplier_in_PLN() { return multiplier_in_PLN; }
        public string getCurrencyCode() { return currencyCode; }
    }
}
