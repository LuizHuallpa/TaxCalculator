using System;
using System.Collections.Generic;
using TaxCalculator.Entities;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data");
                Console.Write("Individual or company (i/c): ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine()); 
                if(c == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    taxPayers.Add(new Individual(healthExpenditures, name, income));

                }else if (c == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(employees,name,income));
                }
                else
                {
                    Console.WriteLine("Incorrect char!!");
                }

            }
            Console.WriteLine();
            double total = 0;
            foreach (TaxPayer payer in taxPayers)
            {
               
                Console.WriteLine($"{payer.Name}: $ {payer.Taxes():F2}");
                total += payer.Taxes();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {total:F2}");
        }
    }
}
