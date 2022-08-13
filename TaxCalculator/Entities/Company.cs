using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Entities
{
    class Company : TaxPayer
    {
        public int Employees { get; set; }

        public Company(int employees, string name, double income) : base(name, income)
        {
            Employees = employees;
        }

        public override double Taxes()
        {
            double tax = 0;
            if (Employees > 10)
                tax = (Income * 0.14);
            else
                tax = (Income * 0.16);

            return tax;
        }
    }
}
