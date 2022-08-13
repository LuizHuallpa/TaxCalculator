using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double income) : base(name, income)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            double tax = 0;
            if (Income < 20000)
                tax = (Income * 0.15) - (HealthExpenditures * 0.5);
            else
                tax = (Income * 0.25) - (HealthExpenditures * 0.5);

            return tax;

        }


    }
}
