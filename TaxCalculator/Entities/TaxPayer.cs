using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double Income { get; set; }



        protected TaxPayer(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Taxes();
    }
}
